namespace PresentationLayer
{
    partial class frmAddField
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkForeignKey = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.cboNullable = new System.Windows.Forms.ComboBox();
            this.cboPrimaryKey = new System.Windows.Forms.ComboBox();
            this.cboUnique = new System.Windows.Forms.ComboBox();
            this.cboOtherConstraints = new System.Windows.Forms.ComboBox();
            this.cboReferenceTable = new System.Windows.Forms.ComboBox();
            this.cboReferenceField = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Field Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Type*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nullable*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primary Key*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unique*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Other Constraints";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comments*";
            // 
            // chkForeignKey
            // 
            this.chkForeignKey.AutoSize = true;
            this.chkForeignKey.Location = new System.Drawing.Point(189, 139);
            this.chkForeignKey.Name = "chkForeignKey";
            this.chkForeignKey.Size = new System.Drawing.Size(88, 17);
            this.chkForeignKey.TabIndex = 7;
            this.chkForeignKey.Text = "Foreign Key?";
            this.chkForeignKey.UseVisualStyleBackColor = true;
            this.chkForeignKey.CheckedChanged += new System.EventHandler(this.chkForeignKey_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Reference Table";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Reference Field";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(9, 33);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(158, 20);
            this.txtFieldName.TabIndex = 10;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(189, 33);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(186, 100);
            this.txtComments.TabIndex = 11;
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
            this.cboDataType.Location = new System.Drawing.Point(9, 72);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(121, 21);
            this.cboDataType.TabIndex = 12;
            // 
            // cboNullable
            // 
            this.cboNullable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNullable.FormattingEnabled = true;
            this.cboNullable.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cboNullable.Location = new System.Drawing.Point(9, 112);
            this.cboNullable.Name = "cboNullable";
            this.cboNullable.Size = new System.Drawing.Size(58, 21);
            this.cboNullable.TabIndex = 13;
            // 
            // cboPrimaryKey
            // 
            this.cboPrimaryKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrimaryKey.FormattingEnabled = true;
            this.cboPrimaryKey.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cboPrimaryKey.Location = new System.Drawing.Point(9, 152);
            this.cboPrimaryKey.Name = "cboPrimaryKey";
            this.cboPrimaryKey.Size = new System.Drawing.Size(58, 21);
            this.cboPrimaryKey.TabIndex = 14;
            // 
            // cboUnique
            // 
            this.cboUnique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnique.FormattingEnabled = true;
            this.cboUnique.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cboUnique.Location = new System.Drawing.Point(9, 192);
            this.cboUnique.Name = "cboUnique";
            this.cboUnique.Size = new System.Drawing.Size(58, 21);
            this.cboUnique.TabIndex = 15;
            // 
            // cboOtherConstraints
            // 
            this.cboOtherConstraints.FormattingEnabled = true;
            this.cboOtherConstraints.Items.AddRange(new object[] {
            "auto-increment"});
            this.cboOtherConstraints.Location = new System.Drawing.Point(9, 232);
            this.cboOtherConstraints.Name = "cboOtherConstraints";
            this.cboOtherConstraints.Size = new System.Drawing.Size(158, 21);
            this.cboOtherConstraints.TabIndex = 16;
            // 
            // cboReferenceTable
            // 
            this.cboReferenceTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReferenceTable.FormattingEnabled = true;
            this.cboReferenceTable.Location = new System.Drawing.Point(189, 176);
            this.cboReferenceTable.Name = "cboReferenceTable";
            this.cboReferenceTable.Size = new System.Drawing.Size(121, 21);
            this.cboReferenceTable.TabIndex = 17;
            this.cboReferenceTable.SelectedIndexChanged += new System.EventHandler(this.cboReferenceTable_SelectedIndexChanged);
            // 
            // cboReferenceField
            // 
            this.cboReferenceField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReferenceField.FormattingEnabled = true;
            this.cboReferenceField.Location = new System.Drawing.Point(189, 216);
            this.cboReferenceField.Name = "cboReferenceField";
            this.cboReferenceField.Size = new System.Drawing.Size(121, 21);
            this.cboReferenceField.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "asterisk (*) denotes a required field";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAddField);
            this.groupBox1.Controls.Add(this.txtComments);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboReferenceField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboReferenceTable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboOtherConstraints);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboUnique);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboPrimaryKey);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboNullable);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboDataType);
            this.groupBox1.Controls.Add(this.chkForeignKey);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFieldName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 303);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(92, 276);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(75, 23);
            this.btnAddField.TabIndex = 19;
            this.btnAddField.Text = "Add Field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Adding field to:";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(128, 9);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(95, 20);
            this.lblTableName.TabIndex = 22;
            this.lblTableName.Text = "tableName";
            // 
            // frmAddField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 355);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a Field";
            this.Load += new System.EventHandler(this.frmAddField_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkForeignKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.ComboBox cboNullable;
        private System.Windows.Forms.ComboBox cboPrimaryKey;
        private System.Windows.Forms.ComboBox cboUnique;
        private System.Windows.Forms.ComboBox cboOtherConstraints;
        private System.Windows.Forms.ComboBox cboReferenceTable;
        private System.Windows.Forms.ComboBox cboReferenceField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTableName;
    }
}