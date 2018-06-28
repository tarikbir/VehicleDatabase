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
    public partial class ModifyPage : Form
    {
        private string labelText;
        private string addingText = "Adding new...";
        private int selectedCarID = -1;
        private int modifyingListingID;

        private void initPage()
        {
            InitializeComponent();
            Program.fillFromDB(listBoxCars, "t_car", "CONCAT(carID, \". \", carMake, \" \", carModel)");
            Program.fillFromDB(comboBoxCity, "t_city", "cityName");
        }

        public ModifyPage()
        {
            //Add
            initPage();
            checkBoxIsNew.Enabled = false;
            checkBoxIsNew.Checked = true;
        }

        public ModifyPage(string label, int modID)
        {
            //Modify
            initPage();
            labelListingName.Text = label;
            labelText = label;
            modifyingListingID = modID;
        }

        private void checkBoxIsNew_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsNew.Checked)
            {
                labelListingName.Enabled = false;
                labelListingName.Text = addingText;
            }
            else
            {
                labelListingName.Enabled = true;
                labelListingName.Text = labelText;
            }
        }

        private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedIndex<9)
                Int32.TryParse(listBoxCars.SelectedItem.ToString().Substring(0, 1), out selectedCarID);
            else
                Int32.TryParse(listBoxCars.SelectedItem.ToString().Substring(0, 2), out selectedCarID);
            textBoxFuel.Text = Program.getSQLCell("SELECT fuelName FROM t_fuel as F, t_car as C WHERE C.fuelID = F.fuelID AND C.carID = " + selectedCarID);
            textBoxTransmission.Text = Program.getSQLCell("SELECT transmissionName FROM t_transmission as T, t_car as C WHERE C.transmissionID = T.transmissionID AND C.carID = " + selectedCarID);
            textBoxColor.Text = Program.getSQLCell("SELECT colorName FROM t_color as T, t_car as C WHERE C.colorID = T.colorID AND C.carID = " + selectedCarID);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string cityID = "";
            try
            {
                cityID = Program.getSQLCell("SELECT cityID from t_city WHERE cityName LIKE \"" + comboBoxCity.SelectedItem.ToString() + "\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show("City cannot be found! \n"+ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBoxIsNew.Checked)
            {
                DateTime date = DateTime.Now;
                string dateToString = date.ToString("yyyy-MM-dd");
                if (Program.sendSingleQuery("INSERT INTO t_listings(listingName, listingCost, listingKM, listingDate, carID, cityID) VALUES (\"" + textBoxListing.Text + "\", \"" +
                    textBoxCost.Text + "\", \"" + textBoxMileage.Text + "\", \"" + dateToString + "\", \"" + selectedCarID + "\", \"" + cityID + "\")"))
                {
                    MessageBox.Show("Successfully created the listing.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There was an error while creating the listing.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (Program.sendSingleQuery("UPDATE t_listings SET listingName = \"" + textBoxListing.Text + "\", listingCost = \"" + textBoxCost.Text + "\", " +
                    "listingKM = \"" + textBoxMileage.Text + "\", carID = \"" + selectedCarID + "\", cityID = \"" + cityID + "\" WHERE " +
                    "listingID = " + modifyingListingID))
                {
                    MessageBox.Show("Successfully created the listing.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There was an error while creating the listing.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Close();
        }
    }
}
