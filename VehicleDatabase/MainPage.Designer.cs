namespace VehicleDatabase
{
    partial class MainPage
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageListDB = new System.Windows.Forms.TabPage();
            this.buttonModifyTables = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioOrderDescending = new System.Windows.Forms.RadioButton();
            this.radioOrderAscending = new System.Windows.Forms.RadioButton();
            this.radioSortDate = new System.Windows.Forms.RadioButton();
            this.radioSortMileage = new System.Windows.Forms.RadioButton();
            this.radioSortPrice = new System.Windows.Forms.RadioButton();
            this.radioSortModel = new System.Windows.Forms.RadioButton();
            this.radioSortMake = new System.Windows.Forms.RadioButton();
            this.radioSortListing = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textListingName = new System.Windows.Forms.TextBox();
            this.checkName = new System.Windows.Forms.CheckBox();
            this.checkCity = new System.Windows.Forms.CheckBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboCity = new System.Windows.Forms.ComboBox();
            this.checkPrice = new System.Windows.Forms.CheckBox();
            this.comboFuel = new System.Windows.Forms.ComboBox();
            this.checkFuel = new System.Windows.Forms.CheckBox();
            this.comboTransmission = new System.Windows.Forms.ComboBox();
            this.checkTransmission = new System.Windows.Forms.CheckBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.checkMileage = new System.Windows.Forms.CheckBox();
            this.comboTimeOnMarket = new System.Windows.Forms.ComboBox();
            this.checkColor = new System.Windows.Forms.CheckBox();
            this.textMileageMax = new System.Windows.Forms.TextBox();
            this.checkTime = new System.Windows.Forms.CheckBox();
            this.textPriceMax = new System.Windows.Forms.TextBox();
            this.textPriceMin = new System.Windows.Forms.TextBox();
            this.textMileageMin = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.dataGridDB = new System.Windows.Forms.DataGridView();
            this.buttonList = new System.Windows.Forms.Button();
            this.tabControlForm = new System.Windows.Forms.TabControl();
            this.contextMenuGrid.SuspendLayout();
            this.tabPageListDB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).BeginInit();
            this.tabControlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuGrid
            // 
            this.contextMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAdd,
            this.toolStripModify,
            this.toolStripDelete});
            this.contextMenuGrid.Name = "contextMenuStrip1";
            this.contextMenuGrid.Size = new System.Drawing.Size(113, 70);
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.Size = new System.Drawing.Size(112, 22);
            this.toolStripAdd.Text = "Add";
            this.toolStripAdd.Click += new System.EventHandler(this.toolStripAdd_Click);
            // 
            // toolStripModify
            // 
            this.toolStripModify.Name = "toolStripModify";
            this.toolStripModify.Size = new System.Drawing.Size(112, 22);
            this.toolStripModify.Text = "Modify";
            this.toolStripModify.Click += new System.EventHandler(this.toolStripModify_Click);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(112, 22);
            this.toolStripDelete.Text = "Delete";
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // tabPageListDB
            // 
            this.tabPageListDB.Controls.Add(this.buttonModifyTables);
            this.tabPageListDB.Controls.Add(this.groupBox2);
            this.tabPageListDB.Controls.Add(this.groupBox1);
            this.tabPageListDB.Controls.Add(this.buttonFilter);
            this.tabPageListDB.Controls.Add(this.dataGridDB);
            this.tabPageListDB.Controls.Add(this.buttonList);
            this.tabPageListDB.Location = new System.Drawing.Point(4, 22);
            this.tabPageListDB.Name = "tabPageListDB";
            this.tabPageListDB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListDB.Size = new System.Drawing.Size(1378, 514);
            this.tabPageListDB.TabIndex = 1;
            this.tabPageListDB.Text = "View Database";
            this.tabPageListDB.UseVisualStyleBackColor = true;
            // 
            // buttonModifyTables
            // 
            this.buttonModifyTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyTables.Location = new System.Drawing.Point(8, 455);
            this.buttonModifyTables.Name = "buttonModifyTables";
            this.buttonModifyTables.Size = new System.Drawing.Size(77, 53);
            this.buttonModifyTables.TabIndex = 14;
            this.buttonModifyTables.Text = "Modify Tables";
            this.buttonModifyTables.UseVisualStyleBackColor = true;
            this.buttonModifyTables.Click += new System.EventHandler(this.buttonModifyTables_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.radioSortDate);
            this.groupBox2.Controls.Add(this.radioSortMileage);
            this.groupBox2.Controls.Add(this.radioSortPrice);
            this.groupBox2.Controls.Add(this.radioSortModel);
            this.groupBox2.Controls.Add(this.radioSortMake);
            this.groupBox2.Controls.Add(this.radioSortListing);
            this.groupBox2.Location = new System.Drawing.Point(8, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 178);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorting";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioOrderDescending);
            this.groupBox3.Controls.Add(this.radioOrderAscending);
            this.groupBox3.Location = new System.Drawing.Point(239, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 78);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order";
            // 
            // radioOrderDescending
            // 
            this.radioOrderDescending.AutoSize = true;
            this.radioOrderDescending.Checked = true;
            this.radioOrderDescending.Location = new System.Drawing.Point(7, 47);
            this.radioOrderDescending.Name = "radioOrderDescending";
            this.radioOrderDescending.Size = new System.Drawing.Size(82, 17);
            this.radioOrderDescending.TabIndex = 0;
            this.radioOrderDescending.TabStop = true;
            this.radioOrderDescending.Text = "Descending";
            this.radioOrderDescending.UseVisualStyleBackColor = true;
            // 
            // radioOrderAscending
            // 
            this.radioOrderAscending.AutoSize = true;
            this.radioOrderAscending.Location = new System.Drawing.Point(7, 24);
            this.radioOrderAscending.Name = "radioOrderAscending";
            this.radioOrderAscending.Size = new System.Drawing.Size(75, 17);
            this.radioOrderAscending.TabIndex = 0;
            this.radioOrderAscending.Text = "Ascending";
            this.radioOrderAscending.UseVisualStyleBackColor = true;
            // 
            // radioSortDate
            // 
            this.radioSortDate.AutoSize = true;
            this.radioSortDate.Checked = true;
            this.radioSortDate.Location = new System.Drawing.Point(6, 135);
            this.radioSortDate.Name = "radioSortDate";
            this.radioSortDate.Size = new System.Drawing.Size(63, 17);
            this.radioSortDate.TabIndex = 0;
            this.radioSortDate.TabStop = true;
            this.radioSortDate.Text = "By Date";
            this.radioSortDate.UseVisualStyleBackColor = true;
            // 
            // radioSortMileage
            // 
            this.radioSortMileage.AutoSize = true;
            this.radioSortMileage.Location = new System.Drawing.Point(6, 112);
            this.radioSortMileage.Name = "radioSortMileage";
            this.radioSortMileage.Size = new System.Drawing.Size(77, 17);
            this.radioSortMileage.TabIndex = 0;
            this.radioSortMileage.Text = "By Mileage";
            this.radioSortMileage.UseVisualStyleBackColor = true;
            // 
            // radioSortPrice
            // 
            this.radioSortPrice.AutoSize = true;
            this.radioSortPrice.Location = new System.Drawing.Point(6, 89);
            this.radioSortPrice.Name = "radioSortPrice";
            this.radioSortPrice.Size = new System.Drawing.Size(64, 17);
            this.radioSortPrice.TabIndex = 0;
            this.radioSortPrice.Text = "By Price";
            this.radioSortPrice.UseVisualStyleBackColor = true;
            // 
            // radioSortModel
            // 
            this.radioSortModel.AutoSize = true;
            this.radioSortModel.Location = new System.Drawing.Point(7, 66);
            this.radioSortModel.Name = "radioSortModel";
            this.radioSortModel.Size = new System.Drawing.Size(69, 17);
            this.radioSortModel.TabIndex = 0;
            this.radioSortModel.Text = "By Model";
            this.radioSortModel.UseVisualStyleBackColor = true;
            // 
            // radioSortMake
            // 
            this.radioSortMake.AutoSize = true;
            this.radioSortMake.Location = new System.Drawing.Point(7, 43);
            this.radioSortMake.Name = "radioSortMake";
            this.radioSortMake.Size = new System.Drawing.Size(67, 17);
            this.radioSortMake.TabIndex = 0;
            this.radioSortMake.Text = "By Make";
            this.radioSortMake.UseVisualStyleBackColor = true;
            // 
            // radioSortListing
            // 
            this.radioSortListing.AutoSize = true;
            this.radioSortListing.Location = new System.Drawing.Point(7, 20);
            this.radioSortListing.Name = "radioSortListing";
            this.radioSortListing.Size = new System.Drawing.Size(93, 17);
            this.radioSortListing.TabIndex = 0;
            this.radioSortListing.Text = "By Listing Title";
            this.radioSortListing.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textListingName);
            this.groupBox1.Controls.Add(this.checkName);
            this.groupBox1.Controls.Add(this.checkCity);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.comboCity);
            this.groupBox1.Controls.Add(this.checkPrice);
            this.groupBox1.Controls.Add(this.comboFuel);
            this.groupBox1.Controls.Add(this.checkFuel);
            this.groupBox1.Controls.Add(this.comboTransmission);
            this.groupBox1.Controls.Add(this.checkTransmission);
            this.groupBox1.Controls.Add(this.comboColor);
            this.groupBox1.Controls.Add(this.checkMileage);
            this.groupBox1.Controls.Add(this.comboTimeOnMarket);
            this.groupBox1.Controls.Add(this.checkColor);
            this.groupBox1.Controls.Add(this.textMileageMax);
            this.groupBox1.Controls.Add(this.checkTime);
            this.groupBox1.Controls.Add(this.textPriceMax);
            this.groupBox1.Controls.Add(this.textPriceMin);
            this.groupBox1.Controls.Add(this.textMileageMin);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // textListingName
            // 
            this.textListingName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textListingName.Location = new System.Drawing.Point(156, 17);
            this.textListingName.MaxLength = 11;
            this.textListingName.Name = "textListingName";
            this.textListingName.Size = new System.Drawing.Size(153, 20);
            this.textListingName.TabIndex = 1;
            this.textListingName.Text = "Enter search term here...";
            this.textListingName.Enter += new System.EventHandler(this.textListingName_Enter);
            this.textListingName.Leave += new System.EventHandler(this.textListingName_Leave);
            // 
            // checkName
            // 
            this.checkName.AutoSize = true;
            this.checkName.Location = new System.Drawing.Point(6, 19);
            this.checkName.Name = "checkName";
            this.checkName.Size = new System.Drawing.Size(87, 17);
            this.checkName.TabIndex = 12;
            this.checkName.TabStop = false;
            this.checkName.Text = "Listing Name";
            this.checkName.UseVisualStyleBackColor = true;
            // 
            // checkCity
            // 
            this.checkCity.AutoSize = true;
            this.checkCity.Location = new System.Drawing.Point(6, 42);
            this.checkCity.Name = "checkCity";
            this.checkCity.Size = new System.Drawing.Size(43, 17);
            this.checkCity.TabIndex = 0;
            this.checkCity.TabStop = false;
            this.checkCity.Text = "City";
            this.checkCity.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(156, 205);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(153, 21);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboCity
            // 
            this.comboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCity.Location = new System.Drawing.Point(156, 40);
            this.comboCity.MaxDropDownItems = 10;
            this.comboCity.MaxLength = 40;
            this.comboCity.Name = "comboCity";
            this.comboCity.Size = new System.Drawing.Size(153, 21);
            this.comboCity.TabIndex = 2;
            this.comboCity.SelectedIndexChanged += new System.EventHandler(this.comboCity_SelectedIndexChanged);
            // 
            // checkPrice
            // 
            this.checkPrice.AutoSize = true;
            this.checkPrice.Location = new System.Drawing.Point(6, 65);
            this.checkPrice.Name = "checkPrice";
            this.checkPrice.Size = new System.Drawing.Size(85, 17);
            this.checkPrice.TabIndex = 0;
            this.checkPrice.TabStop = false;
            this.checkPrice.Text = "Price Range";
            this.checkPrice.UseVisualStyleBackColor = true;
            // 
            // comboFuel
            // 
            this.comboFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFuel.Location = new System.Drawing.Point(156, 86);
            this.comboFuel.MaxDropDownItems = 10;
            this.comboFuel.MaxLength = 40;
            this.comboFuel.Name = "comboFuel";
            this.comboFuel.Size = new System.Drawing.Size(153, 21);
            this.comboFuel.TabIndex = 5;
            this.comboFuel.SelectedIndexChanged += new System.EventHandler(this.comboFuel_SelectedIndexChanged);
            // 
            // checkFuel
            // 
            this.checkFuel.AutoSize = true;
            this.checkFuel.Location = new System.Drawing.Point(6, 88);
            this.checkFuel.Name = "checkFuel";
            this.checkFuel.Size = new System.Drawing.Size(73, 17);
            this.checkFuel.TabIndex = 0;
            this.checkFuel.TabStop = false;
            this.checkFuel.Text = "Fuel Type";
            this.checkFuel.UseVisualStyleBackColor = true;
            // 
            // comboTransmission
            // 
            this.comboTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTransmission.Location = new System.Drawing.Point(156, 109);
            this.comboTransmission.MaxDropDownItems = 10;
            this.comboTransmission.MaxLength = 40;
            this.comboTransmission.Name = "comboTransmission";
            this.comboTransmission.Size = new System.Drawing.Size(153, 21);
            this.comboTransmission.TabIndex = 6;
            this.comboTransmission.SelectedIndexChanged += new System.EventHandler(this.comboTransmission_SelectedIndexChanged);
            // 
            // checkTransmission
            // 
            this.checkTransmission.AutoSize = true;
            this.checkTransmission.Location = new System.Drawing.Point(6, 111);
            this.checkTransmission.Name = "checkTransmission";
            this.checkTransmission.Size = new System.Drawing.Size(87, 17);
            this.checkTransmission.TabIndex = 0;
            this.checkTransmission.TabStop = false;
            this.checkTransmission.Text = "Transmission";
            this.checkTransmission.UseVisualStyleBackColor = true;
            // 
            // comboColor
            // 
            this.comboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColor.Location = new System.Drawing.Point(156, 155);
            this.comboColor.MaxDropDownItems = 10;
            this.comboColor.MaxLength = 40;
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(153, 21);
            this.comboColor.TabIndex = 9;
            this.comboColor.SelectedIndexChanged += new System.EventHandler(this.comboColor_SelectedIndexChanged);
            // 
            // checkMileage
            // 
            this.checkMileage.AutoSize = true;
            this.checkMileage.Location = new System.Drawing.Point(6, 134);
            this.checkMileage.Name = "checkMileage";
            this.checkMileage.Size = new System.Drawing.Size(88, 17);
            this.checkMileage.TabIndex = 0;
            this.checkMileage.TabStop = false;
            this.checkMileage.Text = "Mileage (KM)";
            this.checkMileage.UseVisualStyleBackColor = true;
            // 
            // comboTimeOnMarket
            // 
            this.comboTimeOnMarket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTimeOnMarket.Items.AddRange(new object[] {
            "Last day",
            "Last week",
            "Last month",
            "Last year"});
            this.comboTimeOnMarket.Location = new System.Drawing.Point(156, 178);
            this.comboTimeOnMarket.MaxDropDownItems = 10;
            this.comboTimeOnMarket.MaxLength = 40;
            this.comboTimeOnMarket.Name = "comboTimeOnMarket";
            this.comboTimeOnMarket.Size = new System.Drawing.Size(153, 21);
            this.comboTimeOnMarket.TabIndex = 10;
            this.comboTimeOnMarket.SelectedIndexChanged += new System.EventHandler(this.comboTimeOnMarket_SelectedIndexChanged);
            // 
            // checkColor
            // 
            this.checkColor.AutoSize = true;
            this.checkColor.Location = new System.Drawing.Point(6, 157);
            this.checkColor.Name = "checkColor";
            this.checkColor.Size = new System.Drawing.Size(50, 17);
            this.checkColor.TabIndex = 0;
            this.checkColor.TabStop = false;
            this.checkColor.Text = "Color";
            this.checkColor.UseVisualStyleBackColor = true;
            // 
            // textMileageMax
            // 
            this.textMileageMax.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textMileageMax.Location = new System.Drawing.Point(239, 131);
            this.textMileageMax.MaxLength = 11;
            this.textMileageMax.Name = "textMileageMax";
            this.textMileageMax.Size = new System.Drawing.Size(70, 20);
            this.textMileageMax.TabIndex = 8;
            this.textMileageMax.Text = "max";
            this.textMileageMax.Enter += new System.EventHandler(this.textMileageMax_Enter);
            this.textMileageMax.Leave += new System.EventHandler(this.textMileageMax_Leave);
            // 
            // checkTime
            // 
            this.checkTime.AutoSize = true;
            this.checkTime.Location = new System.Drawing.Point(6, 180);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(100, 17);
            this.checkTime.TabIndex = 0;
            this.checkTime.TabStop = false;
            this.checkTime.Text = "Time on Market";
            this.checkTime.UseVisualStyleBackColor = true;
            // 
            // textPriceMax
            // 
            this.textPriceMax.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textPriceMax.Location = new System.Drawing.Point(239, 65);
            this.textPriceMax.MaxLength = 11;
            this.textPriceMax.Name = "textPriceMax";
            this.textPriceMax.Size = new System.Drawing.Size(70, 20);
            this.textPriceMax.TabIndex = 4;
            this.textPriceMax.Text = "max";
            this.textPriceMax.Enter += new System.EventHandler(this.textPriceMax_Enter);
            this.textPriceMax.Leave += new System.EventHandler(this.textPriceMax_Leave);
            // 
            // textPriceMin
            // 
            this.textPriceMin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textPriceMin.Location = new System.Drawing.Point(156, 65);
            this.textPriceMin.MaxLength = 11;
            this.textPriceMin.Name = "textPriceMin";
            this.textPriceMin.Size = new System.Drawing.Size(70, 20);
            this.textPriceMin.TabIndex = 3;
            this.textPriceMin.Text = "min";
            this.textPriceMin.Enter += new System.EventHandler(this.textPriceMin_Enter);
            this.textPriceMin.Leave += new System.EventHandler(this.textPriceMin_Leave);
            // 
            // textMileageMin
            // 
            this.textMileageMin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textMileageMin.Location = new System.Drawing.Point(156, 131);
            this.textMileageMin.MaxLength = 11;
            this.textMileageMin.Name = "textMileageMin";
            this.textMileageMin.Size = new System.Drawing.Size(70, 20);
            this.textMileageMin.TabIndex = 7;
            this.textMileageMin.Text = "min";
            this.textMileageMin.Enter += new System.EventHandler(this.textMileageMin_Enter);
            this.textMileageMin.Leave += new System.EventHandler(this.textMileageMin_Leave);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.Location = new System.Drawing.Point(91, 455);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(157, 53);
            this.buttonFilter.TabIndex = 12;
            this.buttonFilter.Text = "Apply Filters";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // dataGridDB
            // 
            this.dataGridDB.AllowUserToAddRows = false;
            this.dataGridDB.AllowUserToDeleteRows = false;
            this.dataGridDB.AllowUserToResizeColumns = false;
            this.dataGridDB.AllowUserToResizeRows = false;
            this.dataGridDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDB.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridDB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridDB.Location = new System.Drawing.Point(416, 3);
            this.dataGridDB.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridDB.Name = "dataGridDB";
            this.dataGridDB.ReadOnly = true;
            this.dataGridDB.RowTemplate.Height = 24;
            this.dataGridDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDB.ShowEditingIcon = false;
            this.dataGridDB.Size = new System.Drawing.Size(959, 508);
            this.dataGridDB.TabIndex = 0;
            this.dataGridDB.TabStop = false;
            this.dataGridDB.VirtualMode = true;
            this.dataGridDB.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridDB_CellMouseClick);
            // 
            // buttonList
            // 
            this.buttonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Location = new System.Drawing.Point(254, 455);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(157, 53);
            this.buttonList.TabIndex = 13;
            this.buttonList.Text = "Show All Listings";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // tabControlForm
            // 
            this.tabControlForm.Controls.Add(this.tabPageListDB);
            this.tabControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlForm.Location = new System.Drawing.Point(0, 0);
            this.tabControlForm.Name = "tabControlForm";
            this.tabControlForm.SelectedIndex = 0;
            this.tabControlForm.Size = new System.Drawing.Size(1386, 540);
            this.tabControlForm.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 540);
            this.Controls.Add(this.tabControlForm);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Vehicle Database Application";
            this.contextMenuGrid.ResumeLayout(false);
            this.tabPageListDB.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).EndInit();
            this.tabControlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuGrid;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripModify;
        private System.Windows.Forms.ToolStripMenuItem toolStripDelete;
        private System.Windows.Forms.TabPage tabPageListDB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioOrderDescending;
        private System.Windows.Forms.RadioButton radioOrderAscending;
        private System.Windows.Forms.RadioButton radioSortDate;
        private System.Windows.Forms.RadioButton radioSortMileage;
        private System.Windows.Forms.RadioButton radioSortPrice;
        private System.Windows.Forms.RadioButton radioSortModel;
        private System.Windows.Forms.RadioButton radioSortMake;
        private System.Windows.Forms.RadioButton radioSortListing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textListingName;
        private System.Windows.Forms.CheckBox checkName;
        private System.Windows.Forms.CheckBox checkCity;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.CheckBox checkPrice;
        private System.Windows.Forms.ComboBox comboFuel;
        private System.Windows.Forms.CheckBox checkFuel;
        private System.Windows.Forms.ComboBox comboTransmission;
        private System.Windows.Forms.CheckBox checkTransmission;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.CheckBox checkMileage;
        private System.Windows.Forms.ComboBox comboTimeOnMarket;
        private System.Windows.Forms.CheckBox checkColor;
        private System.Windows.Forms.TextBox textMileageMax;
        private System.Windows.Forms.CheckBox checkTime;
        private System.Windows.Forms.TextBox textPriceMax;
        private System.Windows.Forms.TextBox textPriceMin;
        private System.Windows.Forms.TextBox textMileageMin;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.DataGridView dataGridDB;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.TabControl tabControlForm;
        private System.Windows.Forms.Button buttonModifyTables;
    }
}

