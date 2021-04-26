
namespace PresentationLayer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuLoadCSVFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadTSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveCSVFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHowTo = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.txtTableDescription = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.lstTables = new System.Windows.Forms.ListView();
            this.colTableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteField = new System.Windows.Forms.Button();
            this.lblTableDescription = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkForeignKey = new System.Windows.Forms.CheckBox();
            this.cboReferenceField = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboReferenceTable = new System.Windows.Forms.ComboBox();
            this.btnAddField = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboOtherConstraints = new System.Windows.Forms.ComboBox();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.cboUnique = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPrimaryKey = new System.Windows.Forms.ComboBox();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboNullable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstFields = new System.Windows.Forms.ListView();
            this.colFieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNullable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForeignKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrimaryKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnique = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOtherConstraints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnBuildSQL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadCSVFile,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1286, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuLoadCSVFile
            // 
            this.mnuLoadCSVFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadTSV,
            this.mnuSaveCSVFile,
            this.mnuExit});
            this.mnuLoadCSVFile.Name = "mnuLoadCSVFile";
            this.mnuLoadCSVFile.Size = new System.Drawing.Size(37, 20);
            this.mnuLoadCSVFile.Text = "File";
            // 
            // mnuLoadTSV
            // 
            this.mnuLoadTSV.Name = "mnuLoadTSV";
            this.mnuLoadTSV.Size = new System.Drawing.Size(143, 22);
            this.mnuLoadTSV.Text = "Load TSV File";
            this.mnuLoadTSV.Click += new System.EventHandler(this.mnuLoadTSV_Click);
            // 
            // mnuSaveCSVFile
            // 
            this.mnuSaveCSVFile.Name = "mnuSaveCSVFile";
            this.mnuSaveCSVFile.Size = new System.Drawing.Size(143, 22);
            this.mnuSaveCSVFile.Text = "Save TSV File";
            this.mnuSaveCSVFile.Click += new System.EventHandler(this.mnuSaveCSVFile_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(143, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuHowTo});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuAbout.Text = "About";
            // 
            // mnuHowTo
            // 
            this.mnuHowTo.Name = "mnuHowTo";
            this.mnuHowTo.Size = new System.Drawing.Size(180, 22);
            this.mnuHowTo.Text = "How to...";
            this.mnuHowTo.Click += new System.EventHandler(this.mnuHowTo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTableName);
            this.groupBox1.Controls.Add(this.txtTableDescription);
            this.groupBox1.Controls.Add(this.txtTableName);
            this.groupBox1.Location = new System.Drawing.Point(158, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a Table";
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(658, 17);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 23);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Table Description*";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(7, 46);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(69, 13);
            this.lblTableName.TabIndex = 2;
            this.lblTableName.Text = "Table Name*";
            // 
            // txtTableDescription
            // 
            this.txtTableDescription.Location = new System.Drawing.Point(180, 19);
            this.txtTableDescription.Name = "txtTableDescription";
            this.txtTableDescription.Size = new System.Drawing.Size(472, 20);
            this.txtTableDescription.TabIndex = 2;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(10, 19);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(164, 20);
            this.txtTableName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteTable);
            this.groupBox2.Controls.Add(this.lstTables);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 259);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tables";
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(10, 230);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(124, 23);
            this.btnDeleteTable.TabIndex = 0;
            this.btnDeleteTable.Text = "Delete Table";
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // lstTables
            // 
            this.lstTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTableName});
            this.lstTables.FullRowSelect = true;
            this.lstTables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstTables.HideSelection = false;
            this.lstTables.Location = new System.Drawing.Point(7, 19);
            this.lstTables.MultiSelect = false;
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(129, 205);
            this.lstTables.TabIndex = 20;
            this.lstTables.TabStop = false;
            this.lstTables.UseCompatibleStateImageBehavior = false;
            this.lstTables.View = System.Windows.Forms.View.Details;
            this.lstTables.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstTables_ItemSelectionChanged);
            // 
            // colTableName
            // 
            this.colTableName.Text = "Table Name";
            this.colTableName.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteField);
            this.groupBox3.Controls.Add(this.lblTableDescription);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lstFields);
            this.groupBox3.Location = new System.Drawing.Point(158, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1124, 383);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fields";
            // 
            // btnDeleteField
            // 
            this.btnDeleteField.Location = new System.Drawing.Point(1005, 245);
            this.btnDeleteField.Name = "btnDeleteField";
            this.btnDeleteField.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteField.TabIndex = 1;
            this.btnDeleteField.Text = "Delete Field";
            this.btnDeleteField.UseVisualStyleBackColor = true;
            this.btnDeleteField.Click += new System.EventHandler(this.btnDeleteField_Click);
            // 
            // lblTableDescription
            // 
            this.lblTableDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTableDescription.Location = new System.Drawing.Point(6, 245);
            this.lblTableDescription.Name = "lblTableDescription";
            this.lblTableDescription.Size = new System.Drawing.Size(993, 23);
            this.lblTableDescription.TabIndex = 18;
            this.lblTableDescription.Text = "Table Description";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkForeignKey);
            this.groupBox4.Controls.Add(this.cboReferenceField);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.cboReferenceTable);
            this.groupBox4.Controls.Add(this.btnAddField);
            this.groupBox4.Controls.Add(this.txtComments);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cboOtherConstraints);
            this.groupBox4.Controls.Add(this.txtFieldName);
            this.groupBox4.Controls.Add(this.cboUnique);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cboPrimaryKey);
            this.groupBox4.Controls.Add(this.cboDataType);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cboNullable);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(7, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1111, 101);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add A Field";
            // 
            // chkForeignKey
            // 
            this.chkForeignKey.AutoSize = true;
            this.chkForeignKey.Location = new System.Drawing.Point(44, 76);
            this.chkForeignKey.Name = "chkForeignKey";
            this.chkForeignKey.Size = new System.Drawing.Size(88, 17);
            this.chkForeignKey.TabIndex = 12;
            this.chkForeignKey.Text = "Foreign Key?";
            this.chkForeignKey.UseVisualStyleBackColor = true;
            this.chkForeignKey.CheckedChanged += new System.EventHandler(this.chkForeignKey_CheckedChanged);
            // 
            // cboReferenceField
            // 
            this.cboReferenceField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReferenceField.FormattingEnabled = true;
            this.cboReferenceField.Location = new System.Drawing.Point(266, 74);
            this.cboReferenceField.Name = "cboReferenceField";
            this.cboReferenceField.Size = new System.Drawing.Size(121, 21);
            this.cboReferenceField.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(263, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Reference Field";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Reference Table";
            // 
            // cboReferenceTable
            // 
            this.cboReferenceTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReferenceTable.FormattingEnabled = true;
            this.cboReferenceTable.Location = new System.Drawing.Point(138, 74);
            this.cboReferenceTable.Name = "cboReferenceTable";
            this.cboReferenceTable.Size = new System.Drawing.Size(121, 21);
            this.cboReferenceTable.TabIndex = 13;
            this.cboReferenceTable.SelectedIndexChanged += new System.EventHandler(this.cboReferenceTable_SelectedIndexChanged);
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(1013, 65);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(87, 30);
            this.btnAddField.TabIndex = 15;
            this.btnAddField.Text = "Add Field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(665, 33);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(342, 61);
            this.txtComments.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Field Name*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Comments*";
            // 
            // cboOtherConstraints
            // 
            this.cboOtherConstraints.FormattingEnabled = true;
            this.cboOtherConstraints.Items.AddRange(new object[] {
            "auto-increment"});
            this.cboOtherConstraints.Location = new System.Drawing.Point(398, 32);
            this.cboOtherConstraints.Name = "cboOtherConstraints";
            this.cboOtherConstraints.Size = new System.Drawing.Size(261, 21);
            this.cboOtherConstraints.TabIndex = 10;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(6, 32);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(125, 20);
            this.txtFieldName.TabIndex = 4;
            // 
            // cboUnique
            // 
            this.cboUnique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnique.FormattingEnabled = true;
            this.cboUnique.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboUnique.Location = new System.Drawing.Point(340, 32);
            this.cboUnique.Name = "cboUnique";
            this.cboUnique.Size = new System.Drawing.Size(52, 21);
            this.cboUnique.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Other Constraints";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Type*";
            // 
            // cboPrimaryKey
            // 
            this.cboPrimaryKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrimaryKey.FormattingEnabled = true;
            this.cboPrimaryKey.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboPrimaryKey.Location = new System.Drawing.Point(266, 32);
            this.cboPrimaryKey.Name = "cboPrimaryKey";
            this.cboPrimaryKey.Size = new System.Drawing.Size(68, 21);
            this.cboPrimaryKey.TabIndex = 8;
            // 
            // cboDataType
            // 
            this.cboDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Items.AddRange(new object[] {
            "INT",
            "VARCHAR(50)",
            "VARCHAR(250)",
            "DATE",
            "ENUM(\'Y\', \'N\')",
            "DECIMAL(20, 2)"});
            this.cboDataType.Location = new System.Drawing.Point(137, 32);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(71, 21);
            this.cboDataType.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Unique*";
            // 
            // cboNullable
            // 
            this.cboNullable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNullable.FormattingEnabled = true;
            this.cboNullable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboNullable.Location = new System.Drawing.Point(214, 32);
            this.cboNullable.Name = "cboNullable";
            this.cboNullable.Size = new System.Drawing.Size(42, 21);
            this.cboNullable.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nullable*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Primary Key*";
            // 
            // lstFields
            // 
            this.lstFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFieldName,
            this.colDataType,
            this.colNullable,
            this.colForeignKey,
            this.colPrimaryKey,
            this.colUnique,
            this.colOtherConstraints,
            this.colComments});
            this.lstFields.FullRowSelect = true;
            this.lstFields.GridLines = true;
            this.lstFields.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstFields.HideSelection = false;
            this.lstFields.Location = new System.Drawing.Point(7, 19);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(1100, 214);
            this.lstFields.TabIndex = 0;
            this.lstFields.TabStop = false;
            this.lstFields.UseCompatibleStateImageBehavior = false;
            this.lstFields.View = System.Windows.Forms.View.Details;
            this.lstFields.SelectedIndexChanged += new System.EventHandler(this.lstFields_SelectedIndexChanged);
            // 
            // colFieldName
            // 
            this.colFieldName.Text = "Field Name";
            this.colFieldName.Width = 108;
            // 
            // colDataType
            // 
            this.colDataType.Text = "Data Type";
            this.colDataType.Width = 72;
            // 
            // colNullable
            // 
            this.colNullable.Text = "Nullable";
            this.colNullable.Width = 50;
            // 
            // colForeignKey
            // 
            this.colForeignKey.Text = "Foreign Key";
            this.colForeignKey.Width = 69;
            // 
            // colPrimaryKey
            // 
            this.colPrimaryKey.Text = "Primary Key";
            this.colPrimaryKey.Width = 68;
            // 
            // colUnique
            // 
            this.colUnique.Text = "Unique";
            this.colUnique.Width = 49;
            // 
            // colOtherConstraints
            // 
            this.colOtherConstraints.Text = "Other Constraints";
            this.colOtherConstraints.Width = 99;
            // 
            // colComments
            // 
            this.colComments.Text = "Comments";
            this.colComments.Width = 348;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSaveData);
            this.groupBox5.Controls.Add(this.btnLoadData);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(140, 80);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Files";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(10, 48);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(121, 23);
            this.btnSaveData.TabIndex = 14;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(10, 19);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(121, 23);
            this.btnLoadData.TabIndex = 15;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnBuildSQL
            // 
            this.btnBuildSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildSQL.Location = new System.Drawing.Point(6, 55);
            this.btnBuildSQL.Name = "btnBuildSQL";
            this.btnBuildSQL.Size = new System.Drawing.Size(130, 52);
            this.btnBuildSQL.TabIndex = 15;
            this.btnBuildSQL.Text = "Build SQL";
            this.btnBuildSQL.UseVisualStyleBackColor = true;
            this.btnBuildSQL.Click += new System.EventHandler(this.btnBuildSQL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "asterisk (*) denotes a required field";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txtDatabaseName);
            this.groupBox6.Controls.Add(this.btnBuildSQL);
            this.groupBox6.Location = new System.Drawing.Point(12, 366);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(140, 115);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Build SQL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Database Name";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(6, 32);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(130, 20);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 497);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL Database Builder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadCSVFile;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadTSV;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveCSVFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.TextBox txtTableDescription;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstFields;
        private System.Windows.Forms.ColumnHeader colFieldName;
        private System.Windows.Forms.ColumnHeader colDataType;
        private System.Windows.Forms.ColumnHeader colNullable;
        private System.Windows.Forms.ColumnHeader colForeignKey;
        private System.Windows.Forms.ColumnHeader colPrimaryKey;
        private System.Windows.Forms.ColumnHeader colUnique;
        private System.Windows.Forms.ColumnHeader colOtherConstraints;
        private System.Windows.Forms.ColumnHeader colComments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnBuildSQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboOtherConstraints;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.ComboBox cboUnique;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPrimaryKey;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboNullable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteField;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label lblTableDescription;
        private System.Windows.Forms.ListView lstTables;
        private System.Windows.Forms.ColumnHeader colTableName;
        private System.Windows.Forms.ComboBox cboReferenceField;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboReferenceTable;
        private System.Windows.Forms.CheckBox chkForeignKey;
        private System.Windows.Forms.ToolStripMenuItem mnuHowTo;
    }
}

