namespace VehicleDatabase
{
    partial class ModifyPage
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
            this.textBoxListing = new System.Windows.Forms.TextBox();
            this.labelListingName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.checkBoxIsNew = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFuel = new System.Windows.Forms.TextBox();
            this.textBoxTransmission = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxListing
            // 
            this.textBoxListing.Location = new System.Drawing.Point(111, 54);
            this.textBoxListing.MaxLength = 255;
            this.textBoxListing.Name = "textBoxListing";
            this.textBoxListing.Size = new System.Drawing.Size(479, 20);
            this.textBoxListing.TabIndex = 1;
            // 
            // labelListingName
            // 
            this.labelListingName.AutoSize = true;
            this.labelListingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListingName.Location = new System.Drawing.Point(13, 13);
            this.labelListingName.Name = "labelListingName";
            this.labelListingName.Size = new System.Drawing.Size(91, 20);
            this.labelListingName.TabIndex = 1;
            this.labelListingName.Text = "listingName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listing Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mileage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Car";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(111, 130);
            this.textBoxCost.MaxLength = 11;
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(121, 20);
            this.textBoxCost.TabIndex = 3;
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Location = new System.Drawing.Point(111, 168);
            this.textBoxMileage.MaxLength = 11;
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(121, 20);
            this.textBoxMileage.TabIndex = 4;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(111, 92);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 2;
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(112, 206);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(139, 134);
            this.listBoxCars.TabIndex = 5;
            this.listBoxCars.SelectedIndexChanged += new System.EventHandler(this.listBoxCars_SelectedIndexChanged);
            // 
            // checkBoxIsNew
            // 
            this.checkBoxIsNew.AutoSize = true;
            this.checkBoxIsNew.Location = new System.Drawing.Point(13, 415);
            this.checkBoxIsNew.Name = "checkBoxIsNew";
            this.checkBoxIsNew.Size = new System.Drawing.Size(132, 17);
            this.checkBoxIsNew.TabIndex = 50;
            this.checkBoxIsNew.TabStop = false;
            this.checkBoxIsNew.Text = "Create as a new listing";
            this.checkBoxIsNew.UseVisualStyleBackColor = true;
            this.checkBoxIsNew.CheckedChanged += new System.EventHandler(this.checkBoxIsNew_CheckedChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(493, 379);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(157, 53);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fuel Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Transmission Type";
            // 
            // textBoxFuel
            // 
            this.textBoxFuel.Location = new System.Drawing.Point(365, 206);
            this.textBoxFuel.MaxLength = 80;
            this.textBoxFuel.Name = "textBoxFuel";
            this.textBoxFuel.ReadOnly = true;
            this.textBoxFuel.Size = new System.Drawing.Size(121, 20);
            this.textBoxFuel.TabIndex = 60;
            this.textBoxFuel.TabStop = false;
            // 
            // textBoxTransmission
            // 
            this.textBoxTransmission.Location = new System.Drawing.Point(365, 251);
            this.textBoxTransmission.MaxLength = 80;
            this.textBoxTransmission.Name = "textBoxTransmission";
            this.textBoxTransmission.ReadOnly = true;
            this.textBoxTransmission.Size = new System.Drawing.Size(121, 20);
            this.textBoxTransmission.TabIndex = 60;
            this.textBoxTransmission.TabStop = false;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(365, 296);
            this.textBoxColor.MaxLength = 80;
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.ReadOnly = true;
            this.textBoxColor.Size = new System.Drawing.Size(121, 20);
            this.textBoxColor.TabIndex = 60;
            this.textBoxColor.TabStop = false;
            // 
            // ModifyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 444);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.checkBoxIsNew);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.textBoxMileage);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxTransmission);
            this.Controls.Add(this.textBoxFuel);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelListingName);
            this.Controls.Add(this.textBoxListing);
            this.Name = "ModifyPage";
            this.Text = "Modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxListing;
        private System.Windows.Forms.Label labelListingName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.CheckBox checkBoxIsNew;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFuel;
        private System.Windows.Forms.TextBox textBoxTransmission;
        private System.Windows.Forms.TextBox textBoxColor;
    }
}