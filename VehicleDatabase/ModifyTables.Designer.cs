namespace VehicleDatabase
{
    partial class ModifyTables
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyTables));
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxTables = new System.Windows.Forms.GroupBox();
            this.radioButtonCity = new System.Windows.Forms.RadioButton();
            this.radioButtonFuelType = new System.Windows.Forms.RadioButton();
            this.radioButtonTransmission = new System.Windows.Forms.RadioButton();
            this.radioButtonColor = new System.Windows.Forms.RadioButton();
            this.groupBoxCar = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCarColor = new System.Windows.Forms.TextBox();
            this.textBoxCarFuel = new System.Windows.Forms.TextBox();
            this.textBoxCarTransmission = new System.Windows.Forms.TextBox();
            this.textBoxCarModel = new System.Windows.Forms.TextBox();
            this.textBoxCarMake = new System.Windows.Forms.TextBox();
            this.checkBoxCarEnable = new System.Windows.Forms.CheckBox();
            this.buttonOpenDatabase = new System.Windows.Forms.Button();
            this.groupBoxTables.SuspendLayout();
            this.groupBoxCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(64, 49);
            this.textBoxID.MaxLength = 11;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add elements to the database...";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(27, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(15, 265);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(161, 58);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Location = new System.Drawing.Point(197, 265);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(161, 58);
            this.buttonModify.TabIndex = 4;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(381, 265);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(161, 58);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(64, 79);
            this.textBoxName.MaxLength = 40;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // groupBoxTables
            // 
            this.groupBoxTables.Controls.Add(this.radioButtonCity);
            this.groupBoxTables.Controls.Add(this.radioButtonFuelType);
            this.groupBoxTables.Controls.Add(this.radioButtonTransmission);
            this.groupBoxTables.Controls.Add(this.radioButtonColor);
            this.groupBoxTables.Location = new System.Drawing.Point(17, 118);
            this.groupBoxTables.Name = "groupBoxTables";
            this.groupBoxTables.Size = new System.Drawing.Size(119, 132);
            this.groupBoxTables.TabIndex = 9;
            this.groupBoxTables.TabStop = false;
            this.groupBoxTables.Text = "Tables";
            // 
            // radioButtonCity
            // 
            this.radioButtonCity.AutoSize = true;
            this.radioButtonCity.Location = new System.Drawing.Point(9, 98);
            this.radioButtonCity.Name = "radioButtonCity";
            this.radioButtonCity.Size = new System.Drawing.Size(42, 17);
            this.radioButtonCity.TabIndex = 3;
            this.radioButtonCity.Text = "City";
            this.radioButtonCity.UseVisualStyleBackColor = true;
            this.radioButtonCity.CheckedChanged += new System.EventHandler(this.radioButtonCity_CheckedChanged);
            // 
            // radioButtonFuelType
            // 
            this.radioButtonFuelType.AutoSize = true;
            this.radioButtonFuelType.Location = new System.Drawing.Point(9, 75);
            this.radioButtonFuelType.Name = "radioButtonFuelType";
            this.radioButtonFuelType.Size = new System.Drawing.Size(72, 17);
            this.radioButtonFuelType.TabIndex = 2;
            this.radioButtonFuelType.Text = "Fuel Type";
            this.radioButtonFuelType.UseVisualStyleBackColor = true;
            this.radioButtonFuelType.CheckedChanged += new System.EventHandler(this.radioButtonFuelType_CheckedChanged);
            // 
            // radioButtonTransmission
            // 
            this.radioButtonTransmission.AutoSize = true;
            this.radioButtonTransmission.Location = new System.Drawing.Point(9, 52);
            this.radioButtonTransmission.Name = "radioButtonTransmission";
            this.radioButtonTransmission.Size = new System.Drawing.Size(86, 17);
            this.radioButtonTransmission.TabIndex = 1;
            this.radioButtonTransmission.Text = "Transmission";
            this.radioButtonTransmission.UseVisualStyleBackColor = true;
            this.radioButtonTransmission.CheckedChanged += new System.EventHandler(this.radioButtonTransmission_CheckedChanged);
            // 
            // radioButtonColor
            // 
            this.radioButtonColor.AutoSize = true;
            this.radioButtonColor.Checked = true;
            this.radioButtonColor.Location = new System.Drawing.Point(9, 29);
            this.radioButtonColor.Name = "radioButtonColor";
            this.radioButtonColor.Size = new System.Drawing.Size(49, 17);
            this.radioButtonColor.TabIndex = 0;
            this.radioButtonColor.TabStop = true;
            this.radioButtonColor.Text = "Color";
            this.radioButtonColor.UseVisualStyleBackColor = true;
            this.radioButtonColor.CheckedChanged += new System.EventHandler(this.radioButtonColor_CheckedChanged);
            // 
            // groupBoxCar
            // 
            this.groupBoxCar.Controls.Add(this.label9);
            this.groupBoxCar.Controls.Add(this.label8);
            this.groupBoxCar.Controls.Add(this.label7);
            this.groupBoxCar.Controls.Add(this.label6);
            this.groupBoxCar.Controls.Add(this.label5);
            this.groupBoxCar.Controls.Add(this.textBoxCarColor);
            this.groupBoxCar.Controls.Add(this.textBoxCarFuel);
            this.groupBoxCar.Controls.Add(this.textBoxCarTransmission);
            this.groupBoxCar.Controls.Add(this.textBoxCarModel);
            this.groupBoxCar.Controls.Add(this.textBoxCarMake);
            this.groupBoxCar.Enabled = false;
            this.groupBoxCar.Location = new System.Drawing.Point(275, 13);
            this.groupBoxCar.Name = "groupBoxCar";
            this.groupBoxCar.Size = new System.Drawing.Size(263, 237);
            this.groupBoxCar.TabIndex = 10;
            this.groupBoxCar.TabStop = false;
            this.groupBoxCar.Text = "Car Properties";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Color ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fuel ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Transmission ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Car Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Car Make";
            // 
            // textBoxCarColor
            // 
            this.textBoxCarColor.Location = new System.Drawing.Point(155, 156);
            this.textBoxCarColor.MaxLength = 11;
            this.textBoxCarColor.Name = "textBoxCarColor";
            this.textBoxCarColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarColor.TabIndex = 5;
            // 
            // textBoxCarFuel
            // 
            this.textBoxCarFuel.Location = new System.Drawing.Point(155, 126);
            this.textBoxCarFuel.MaxLength = 11;
            this.textBoxCarFuel.Name = "textBoxCarFuel";
            this.textBoxCarFuel.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarFuel.TabIndex = 4;
            // 
            // textBoxCarTransmission
            // 
            this.textBoxCarTransmission.Location = new System.Drawing.Point(155, 96);
            this.textBoxCarTransmission.MaxLength = 11;
            this.textBoxCarTransmission.Name = "textBoxCarTransmission";
            this.textBoxCarTransmission.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarTransmission.TabIndex = 3;
            // 
            // textBoxCarModel
            // 
            this.textBoxCarModel.Location = new System.Drawing.Point(155, 66);
            this.textBoxCarModel.MaxLength = 11;
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarModel.TabIndex = 2;
            // 
            // textBoxCarMake
            // 
            this.textBoxCarMake.Location = new System.Drawing.Point(155, 36);
            this.textBoxCarMake.MaxLength = 11;
            this.textBoxCarMake.Name = "textBoxCarMake";
            this.textBoxCarMake.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarMake.TabIndex = 1;
            // 
            // checkBoxCarEnable
            // 
            this.checkBoxCarEnable.Location = new System.Drawing.Point(142, 205);
            this.checkBoxCarEnable.Name = "checkBoxCarEnable";
            this.checkBoxCarEnable.Size = new System.Drawing.Size(127, 40);
            this.checkBoxCarEnable.TabIndex = 11;
            this.checkBoxCarEnable.Text = "Add/Modify/Remove a Car";
            this.checkBoxCarEnable.UseVisualStyleBackColor = true;
            this.checkBoxCarEnable.CheckedChanged += new System.EventHandler(this.checkBoxCarEnable_CheckedChanged);
            // 
            // buttonOpenDatabase
            // 
            this.buttonOpenDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenDatabase.Location = new System.Drawing.Point(142, 170);
            this.buttonOpenDatabase.Name = "buttonOpenDatabase";
            this.buttonOpenDatabase.Size = new System.Drawing.Size(127, 33);
            this.buttonOpenDatabase.TabIndex = 12;
            this.buttonOpenDatabase.Text = "Open Database";
            this.buttonOpenDatabase.UseVisualStyleBackColor = true;
            this.buttonOpenDatabase.Click += new System.EventHandler(this.buttonOpenDatabase_Click);
            // 
            // ModifyTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 377);
            this.Controls.Add(this.buttonOpenDatabase);
            this.Controls.Add(this.checkBoxCarEnable);
            this.Controls.Add(this.groupBoxCar);
            this.Controls.Add(this.groupBoxTables);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Name = "ModifyTables";
            this.Text = "Add elements to the database...";
            this.groupBoxTables.ResumeLayout(false);
            this.groupBoxTables.PerformLayout();
            this.groupBoxCar.ResumeLayout(false);
            this.groupBoxCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxTables;
        private System.Windows.Forms.RadioButton radioButtonCity;
        private System.Windows.Forms.RadioButton radioButtonFuelType;
        private System.Windows.Forms.RadioButton radioButtonTransmission;
        private System.Windows.Forms.RadioButton radioButtonColor;
        private System.Windows.Forms.GroupBox groupBoxCar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCarColor;
        private System.Windows.Forms.TextBox textBoxCarFuel;
        private System.Windows.Forms.TextBox textBoxCarTransmission;
        private System.Windows.Forms.TextBox textBoxCarModel;
        private System.Windows.Forms.TextBox textBoxCarMake;
        private System.Windows.Forms.CheckBox checkBoxCarEnable;
        private System.Windows.Forms.Button buttonOpenDatabase;
    }
}