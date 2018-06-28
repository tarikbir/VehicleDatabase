using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleDatabase
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            Console.WriteLine("DEBUG: Initializing form...");
            InitializeComponent();
            Console.WriteLine("DEBUG: Checking DB availability...");
            while (!Program.PingHost("localhost", 3306))
            {
                DialogResult dr = MessageBox.Show("Database is not available!", "Critical Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.Cancel)
                    System.Environment.Exit(0); // Application.Exit() doesn't work.
            }
            Console.WriteLine("DEBUG: Getting lists from DB...");
            Program.fillFromDB(comboCity, "t_city", "cityName");
            Program.fillFromDB(comboColor, "t_color", "colorName");
            Program.fillFromDB(comboFuel, "t_fuel", "fuelName");
            Program.fillFromDB(comboTransmission, "t_transmission", "transmissionName");
            buttonList_Click(null, null);
            this.AcceptButton = buttonFilter;
            Console.WriteLine("DEBUG: Initializing done.");
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            deselect();
            string sql = "SELECT listingName as \"Listing Title\", CAR.carMake as \"Make\", CAR.carModel as \"Model\", listingCost as \"Price\", listingKM as \"Mileage(KM)\"," +
                            " listingDate as \"Listing Date\", C.cityName as \"City\", CAR.colorName as \"Color\", CAR.fuelName as \"Fuel\", CAR.transmissionName as \"Transmission\"" +
                            ", CAR.carID, listingID FROM t_listings as L INNER JOIN t_city as C ON C.cityID = L.cityID INNER JOIN (SELECT C.carID, C.carMake, C.carModel, COL.colorName," +
                            " F.fuelName, T.transmissionName FROM t_car as C INNER JOIN t_color as COL ON C.colorID = COL.colorID INNER JOIN t_fuel as F ON C.fuelID = F.fuelID INNER JOIN" +
                            " t_transmission as T ON C.transmissionID = T.transmissionID) as CAR ON CAR.carID = L.carID";
            //Console.WriteLine("DEBUG: Filter button clicked.");
            #region Check for filters
            if (checkName.Checked) sql += " AND (listingName LIKE \"%" + textListingName.Text + "%\" OR CONCAT(CAR.carMake, \" \" , CAR.carModel) LIKE \"%" 
                    + textListingName.Text + "%\")";
            if (checkCity.Checked) sql += " AND C.cityname = \"" + comboCity.SelectedItem + "\"";
            if (checkPrice.Checked)
            {
                if (textPriceMin.Text != "min")
                {
                    try
                    {
                        Int32.Parse(textPriceMin.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid text at minimum price!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    sql += " AND listingCost >= " + textPriceMin.Text;
                }
                if (textPriceMax.Text != "max")
                {
                    try
                    {
                        Int32.Parse(textPriceMax.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid text at maximum price!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    sql += " AND listingCost <= " + textPriceMax.Text;
                }
            }
            if (checkFuel.Checked) sql += " AND CAR.fuelName = \"" + comboFuel.SelectedItem + "\"";
            if (checkTransmission.Checked) sql += " AND CAR.transmissionName = \"" + comboTransmission.SelectedItem + "\"";
            if (checkMileage.Checked)
            {
                if (textMileageMin.Text != "min")
                {
                    try
                    {
                        Int32.Parse(textMileageMin.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid text at minimum mileage!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    sql += " AND listingKM >= " + textMileageMin.Text;
                }
                if (textMileageMax.Text != "max")
                {
                    try
                    {
                        Int32.Parse(textMileageMax.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid text at maximum mileage!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    sql += " AND listingKM <= " + textMileageMax.Text;
                }
            }
            if (checkColor.Checked) sql += " AND CAR.colorName = \"" + comboColor.SelectedItem + "\"";
            if (checkTime.Checked)
            {
                if (comboTimeOnMarket.SelectedIndex == 0)
                {
                    DateTime date = DateTime.Now.AddDays(-1); //Last day
                    string dateToString = date.ToString("yyyyMMdd");
                    sql += " AND listingDate >= \"" + dateToString + "\"";
                }
                else if (comboTimeOnMarket.SelectedIndex == 1)
                {
                    DateTime date = DateTime.Now.AddDays(-7); //Last week
                    string dateToString = date.ToString("yyyyMMdd");
                    sql += " AND listingDate >= \"" + dateToString + "\"";
                }
                else if (comboTimeOnMarket.SelectedIndex == 2)
                {
                    DateTime date = DateTime.Now.AddMonths(-1); //Last month
                    string dateToString = date.ToString("yyyyMMdd");
                    sql += " AND listingDate >= \"" + dateToString + "\"";
                }
                else if (comboTimeOnMarket.SelectedIndex == 3)
                {
                    DateTime date = DateTime.Now.AddYears(-1); //Last year
                    string dateToString = date.ToString("yyyyMMdd");
                    sql += " AND listingDate >= \"" + dateToString + "\"";
                }
            }
            #endregion
            #region Check for sorting
            string sort = "listingDate", order = "DESC";
            if (radioSortListing.Checked)
                sort = "listingName";
            else if (radioSortMake.Checked)
                sort = "CAR.carMake";
            else if (radioSortModel.Checked)
                sort = "CAR.carModel";
            else if (radioSortPrice.Checked)
                sort = "listingCost";
            else if (radioSortMileage.Checked)
                sort = "listingKM";
            else if (radioSortDate.Checked)
                sort = "listingDate";
            if (radioOrderAscending.Checked)
                order = "ASC";
            else if (radioOrderDescending.Checked)
                order = "DESC";
            sql += " ORDER BY " + sort + " " + order;
            #endregion
            Program.fillDataGrid(dataGridDB, sql);
            foreach (DataGridViewColumn column in dataGridDB.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (column.Name.Contains("ID"))
                {
                    column.Visible = false; //10 carID, 11 listingID
                }
            }
        }

        protected void buttonList_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string sql = "SELECT listingName as \"Listing Title\", CAR.carMake as \"Make\", CAR.carModel as \"Model\", listingCost as \"Price\", listingKM as \"Mileage(KM)\"," +
                            " listingDate as \"Listing Date\", C.cityName as \"City\", CAR.colorName as \"Color\", CAR.fuelName as \"Fuel\", CAR.transmissionName as \"Transmission\"" +
                            ", CAR.carID, listingID FROM t_listings as L INNER JOIN t_city as C ON C.cityID = L.cityID INNER JOIN (SELECT C.carID, C.carMake, C.carModel, COL.colorName," +
                            " F.fuelName, T.transmissionName FROM t_car as C INNER JOIN t_color as COL ON C.colorID = COL.colorID INNER JOIN t_fuel as F ON C.fuelID = F.fuelID INNER JOIN" +
                            " t_transmission as T ON C.transmissionID = T.transmissionID) as CAR ON CAR.carID = L.carID ORDER BY listingDate DESC";
            //Console.WriteLine("DEBUG: List button clicked.");
            Program.fillDataGrid(dataGridDB, sql);
            foreach (DataGridViewColumn column in dataGridDB.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (column.Name.Contains("ID"))
                {
                    column.Visible = false;
                }
            }
        }

        private void buttonModifyTables_Click(object sender, EventArgs e)
        {
            ModifyTables mt = new ModifyTables();
            mt.ShowDialog();
            buttonList_Click(sender, e);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboCity.SelectedIndex = -1;
            comboFuel.SelectedIndex = -1;
            comboTransmission.SelectedIndex = -1;
            comboColor.SelectedIndex = -1;
            comboTimeOnMarket.SelectedIndex = -1;
            checkCity.Checked = false;
            checkPrice.Checked = false;
            checkFuel.Checked = false;
            checkTransmission.Checked = false;
            checkMileage.Checked = false;
            checkColor.Checked = false;
            checkTime.Checked = false;
            checkName.Checked = false;
            textPriceMin.Text = "";
            watermarkLeave(textPriceMin, "min");
            textPriceMax.Text = "";
            watermarkLeave(textPriceMax, "max");
            textMileageMin.Text = "";
            watermarkLeave(textMileageMin, "min");
            textMileageMax.Text = "";
            watermarkLeave(textMileageMax, "max");
            textListingName.Text = "";
            watermarkLeave(textListingName, "Enter search term here...");
        }

        private void dataGridDB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip cm = contextMenuGrid;
                int row = e.RowIndex;
                dataGridDB.ClearSelection();
                if (row >= 0)
                {
                    dataGridDB.Rows[row].Selected = true;
                    cm.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            ModifyPage mp = new ModifyPage();
            mp.ShowDialog();
            buttonList_Click(sender, e);
        }

        private void toolStripModify_Click(object sender, EventArgs e)
        {
            if (dataGridDB.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridDB.SelectedRows[0];
                int carID = 0, listID = 0;
                try
                {
                    listID = Int32.Parse(row.Cells[11].Value.ToString());
                    carID = Int32.Parse(row.Cells[10].Value.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
                ModifyPage mp = new ModifyPage("Editing \"" + row.Cells[0].Value.ToString() + "\"", listID);
                mp.Controls["textBoxCost"].Text = row.Cells[3].Value.ToString();
                mp.Controls["textBoxMileage"].Text = row.Cells[4].Value.ToString();
                mp.Controls["textBoxListing"].Text = row.Cells[0].Value.ToString();
                ComboBox cbCity = (ComboBox)mp.Controls["comboBoxCity"];
                cbCity.SelectedItem = row.Cells[6].Value.ToString();
                ListBox lbCar = (ListBox) mp.Controls["listBoxCars"];
                lbCar.SelectedIndex = findCarIndex(lbCar, carID);
                mp.ShowDialog();
                buttonList_Click(sender, e);
            }
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            if (dataGridDB.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridDB.SelectedRows)
                {
                    Program.sendSingleQuery("DELETE FROM t_listings WHERE listingID = " + row.Cells[11].Value);
                    dataGridDB.Rows.Remove(row);
                }
            }
        }

        #region ComboBoxes, TextBoxes and RadioButtons' behavior
        private void comboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCity.SelectedIndex != -1)
                checkCity.Checked = true;
        }

        private void comboFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFuel.SelectedIndex != -1)
                checkFuel.Checked = true;
        }

        private void comboTransmission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTransmission.SelectedIndex != -1)
                checkTransmission.Checked = true;
        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboColor.SelectedIndex != -1)
                checkColor.Checked = true;
        }

        private void comboTimeOnMarket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTimeOnMarket.SelectedIndex != -1)
                checkTime.Checked = true;
        }

        private void textPriceMin_Enter(object sender, EventArgs e)
        {
            watermarkEnter(textPriceMin, "min");
        }

        private void textPriceMin_Leave(object sender, EventArgs e)
        {
            if (!watermarkLeave(textPriceMin, "min")) checkPrice.Checked = true;
        }

        private void textPriceMax_Enter(object sender, EventArgs e)
        {
            watermarkEnter(textPriceMax, "max");
        }

        private void textPriceMax_Leave(object sender, EventArgs e)
        {
            if (!watermarkLeave(textPriceMax, "max")) checkPrice.Checked = true;
        }

        private void textMileageMin_Enter(object sender, EventArgs e)
        {
            watermarkEnter(textMileageMin, "min");
        }

        private void textMileageMin_Leave(object sender, EventArgs e)
        {
            if (!watermarkLeave(textMileageMin, "min")) checkMileage.Checked = true;
        }

        private void textMileageMax_Enter(object sender, EventArgs e)
        {
            watermarkEnter(textMileageMax, "max");
        }

        private void textMileageMax_Leave(object sender, EventArgs e)
        {
            if (!watermarkLeave(textMileageMax, "max")) checkMileage.Checked = true;
        }

        private void textListingName_Enter(object sender, EventArgs e)
        {
            watermarkEnter(textListingName, "Enter search term here...");
        }

        private void textListingName_Leave(object sender, EventArgs e)
        {
            if (!watermarkLeave(textListingName, "Enter search term here...")) checkName.Checked = true;
        }
        #endregion

        /*/////////////////////
        /  General Functions  /
        /////////////////////*/

        private bool watermarkLeave(TextBox tb, string watermark)
        {
            if (tb.Text.Length == 0)
            {
                tb.Text = watermark;
                tb.ForeColor = SystemColors.GrayText;
                return true;
            }
            return false;
        }

        private bool watermarkEnter(TextBox tb, string watermark)
        {
            if (tb.Text == watermark)
            {
                tb.Text = "";
                tb.ForeColor = SystemColors.WindowText;
                return true;
            }
            return false;
        }

        private int findCarIndex(ListBox lb, int id)
        {
            int index, i=0;
            foreach (var item in lb.Items)
            {
                if (i < 10)
                    Int32.TryParse(item.ToString().Substring(0, 1), out index);
                else
                    Int32.TryParse(item.ToString().Substring(0, 2), out index);
                i++;
                if (index == id) return (i-1);
            }
            return -1;
        }

        private void deselect()
        {
            this.ActiveControl = null;
        }
    }
}