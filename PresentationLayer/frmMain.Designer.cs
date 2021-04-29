
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddANewTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.lstTables = new System.Windows.Forms.ListView();
            this.colTableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFieldComments = new System.Windows.Forms.Label();
            this.btnDeleteField = new System.Windows.Forms.Button();
            this.btnAddANewField = new System.Windows.Forms.Button();
            this.lblTableDescription = new System.Windows.Forms.Label();
            this.lstFields = new System.Windows.Forms.ListView();
            this.colFieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNullable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForeignKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrimaryKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnique = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOtherConstraints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnBuildSQL = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
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
            this.mnuAbout.Size = new System.Drawing.Size(122, 22);
            this.mnuAbout.Text = "About";
            // 
            // mnuHowTo
            // 
            this.mnuHowTo.Name = "mnuHowTo";
            this.mnuHowTo.Size = new System.Drawing.Size(122, 22);
            this.mnuHowTo.Text = "How to...";
            this.mnuHowTo.Click += new System.EventHandler(this.mnuHowTo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddANewTable);
            this.groupBox2.Controls.Add(this.btnDeleteTable);
            this.groupBox2.Controls.Add(this.lstTables);
            this.groupBox2.Location = new System.Drawing.Point(151, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 335);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tables";
            // 
            // btnAddANewTable
            // 
            this.btnAddANewTable.Location = new System.Drawing.Point(6, 277);
            this.btnAddANewTable.Name = "btnAddANewTable";
            this.btnAddANewTable.Size = new System.Drawing.Size(130, 23);
            this.btnAddANewTable.TabIndex = 20;
            this.btnAddANewTable.Text = "Add a new Table";
            this.btnAddANewTable.UseVisualStyleBackColor = true;
            this.btnAddANewTable.Click += new System.EventHandler(this.btnAddANewTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(6, 306);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(130, 23);
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
            this.lstTables.Size = new System.Drawing.Size(129, 250);
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
            this.groupBox3.Controls.Add(this.lblFieldComments);
            this.groupBox3.Controls.Add(this.btnDeleteField);
            this.groupBox3.Controls.Add(this.btnAddANewField);
            this.groupBox3.Controls.Add(this.lblTableDescription);
            this.groupBox3.Controls.Add(this.lstFields);
            this.groupBox3.Location = new System.Drawing.Point(297, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 335);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fields";
            // 
            // lblFieldComments
            // 
            this.lblFieldComments.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFieldComments.Location = new System.Drawing.Point(4, 272);
            this.lblFieldComments.Name = "lblFieldComments";
            this.lblFieldComments.Size = new System.Drawing.Size(564, 31);
            this.lblFieldComments.TabIndex = 19;
            this.lblFieldComments.Text = "Field Comments:";
            // 
            // btnDeleteField
            // 
            this.btnDeleteField.Location = new System.Drawing.Point(105, 306);
            this.btnDeleteField.Name = "btnDeleteField";
            this.btnDeleteField.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteField.TabIndex = 1;
            this.btnDeleteField.Text = "Delete Field";
            this.btnDeleteField.UseVisualStyleBackColor = true;
            this.btnDeleteField.Click += new System.EventHandler(this.btnDeleteField_Click);
            // 
            // btnAddANewField
            // 
            this.btnAddANewField.Location = new System.Drawing.Point(5, 306);
            this.btnAddANewField.Name = "btnAddANewField";
            this.btnAddANewField.Size = new System.Drawing.Size(94, 23);
            this.btnAddANewField.TabIndex = 18;
            this.btnAddANewField.Text = "Add a new Field";
            this.btnAddANewField.UseVisualStyleBackColor = true;
            this.btnAddANewField.Click += new System.EventHandler(this.btnAddANewField_Click);
            // 
            // lblTableDescription
            // 
            this.lblTableDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTableDescription.Location = new System.Drawing.Point(6, 16);
            this.lblTableDescription.Name = "lblTableDescription";
            this.lblTableDescription.Size = new System.Drawing.Size(562, 36);
            this.lblTableDescription.TabIndex = 18;
            this.lblTableDescription.Text = "Table Description";
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
            this.colOtherConstraints});
            this.lstFields.FullRowSelect = true;
            this.lstFields.GridLines = true;
            this.lstFields.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstFields.HideSelection = false;
            this.lstFields.Location = new System.Drawing.Point(5, 55);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(563, 214);
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
            this.colOtherConstraints.Width = 141;
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
            this.groupBox5.Location = new System.Drawing.Point(5, 27);
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txtDatabaseName);
            this.groupBox6.Controls.Add(this.btnBuildSQL);
            this.groupBox6.Location = new System.Drawing.Point(5, 113);
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
            this.ClientSize = new System.Drawing.Size(880, 373);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL Database Builder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnBuildSQL;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Button btnDeleteField;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label lblTableDescription;
        private System.Windows.Forms.ListView lstTables;
        private System.Windows.Forms.ColumnHeader colTableName;
        private System.Windows.Forms.ToolStripMenuItem mnuHowTo;
        private System.Windows.Forms.Button btnAddANewField;
        private System.Windows.Forms.Label lblFieldComments;
        private System.Windows.Forms.Button btnAddANewTable;
    }
}

