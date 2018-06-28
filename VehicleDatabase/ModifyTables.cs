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
    public partial class ModifyTables : Form
    {
        private string selectedRB = "color";
        private string previousRB = "color";

        public ModifyTables()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool queryR;
            if (checkBoxCarEnable.Checked)
            {
                queryR = Program.sendSingleQuery("INSERT INTO t_car(carMake, carModel, transmissionID, fuelID, colorID) VALUES(\"" + textBoxCarMake.Text + "\", \"" +
                    textBoxCarModel.Text + "\", \"" + textBoxCarTransmission.Text + "\", \"" + textBoxCarFuel.Text + "\", \"" + textBoxCarColor.Text + "\")");
            }
            else
            {
                queryR = Program.sendSingleQuery("INSERT INTO t_" + selectedRB + "(" + selectedRB + "Name) VALUES(\"" + textBoxName.Text + "\")");
            }
            if (queryR)
            {
                MessageBox.Show("Successfully added " + textBoxName.Text + " to the " + selectedRB + " table.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while adding to the table!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            bool queryR;
            if (checkBoxCarEnable.Checked)
            {
                queryR = Program.sendSingleQuery("UPDATE t_car SET carMake = \"" + textBoxCarMake.Text + "\", carModel = \""+ textBoxCarModel.Text +"\", " +
                    "transmissionID = \"" + textBoxCarTransmission.Text  + "\", fuelID = \"" + textBoxCarFuel.Text + "\", colorID = \"" + textBoxCarColor.Text + "\" WHERE carID = " + textBoxID.Text);
            }
            else
            {
                queryR = Program.sendSingleQuery("UPDATE t_" + selectedRB + " SET " + selectedRB + "Name = \"" + textBoxName.Text + "\", " + selectedRB + "ID = \"" + textBoxID.Text + "\" WHERE " +
                    selectedRB + "ID = " + textBoxID.Text);
            }
            if (queryR)
            {
                MessageBox.Show("Successfully modified id: " + textBoxID.Text + " from the " + selectedRB + " table.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while modifying the given ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            bool queryR;
            if (checkBoxCarEnable.Checked)
            {
                queryR = Program.sendSingleQuery("DELETE FROM t_car WHERE carID = " + textBoxID.Text);
            }
            else
            {
                queryR = Program.sendSingleQuery("DELETE FROM t_" + selectedRB + " WHERE " + selectedRB + "ID = " + textBoxID.Text);
            }
            if (queryR)
            {
                MessageBox.Show("Successfully removed id: " + textBoxID.Text + " from the " + selectedRB + " table.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while removing the ID from the table!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void radioButtonTransmission_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTransmission.Checked) selectedRB = "transmission";
        }

        private void radioButtonFuelType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFuelType.Checked) selectedRB = "fuel";
        }

        private void radioButtonCity_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCity.Checked) selectedRB = "city";
        }

        private void radioButtonColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonColor.Checked) selectedRB = "color";
        }

        private void checkBoxCarEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCarEnable.Checked)
            {
                groupBoxCar.Enabled = true;
                groupBoxTables.Enabled = false;
                textBoxName.Enabled = false;
                label4.Enabled = false;
                previousRB = selectedRB;
                selectedRB = "car";
            }
            else
            {
                groupBoxCar.Enabled = false;
                groupBoxTables.Enabled = true;
                textBoxName.Enabled = true;
                label4.Enabled = true;
                selectedRB = previousRB;
            }
        }

        private void buttonOpenDatabase_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/phpmyadmin/db_structure.php?server=1&db=vehicle");
        }
    }
}
