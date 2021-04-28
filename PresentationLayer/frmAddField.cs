using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataObjects;
using LogicLayer;

namespace PresentationLayer
{
    public partial class frmAddField : Form
    {
        private List<Table> tables;
        private Table table;
        private int index;
        private LogicClass logicClass;
        public frmAddField(List<Table> tables, int selectedTableIndex, LogicClass logicClass)
        {
            InitializeComponent();
            this.table = tables[selectedTableIndex];
            this.index = selectedTableIndex;
            this.tables = tables;
            this.logicClass = logicClass;
        }

        private void frmAddField_Load(object sender, EventArgs e)
        {
            lblTableName.Text = table.TableName;
        }

        private void chkForeignKey_CheckedChanged(object sender, EventArgs e)
        {
            /*  This event handler enables and disables the reference table/field
             *  selectors based on whether the user has checked the checkbox or not
            */

            if (chkForeignKey.Checked == true)
            {
                cboReferenceTable.Enabled = true;
                cboReferenceField.Enabled = true;
                updateCboReferenceTableList(tables, index);
            }
            else
            {
                cboReferenceTable.Enabled = false;
                cboReferenceField.Enabled = false;
            }
        }

        private void updateCboReferenceTableList(List<Table> tables, int index)
        {
            /*  This method updates the combobox for choosing a reference table on a
             *  foreign key.
             */

            cboReferenceTable.Items.Clear();
            for (int i = 0; i < tables.Count; i++)
            {

                // This if statement is here because you cannot add foreign key references
                // from tables that are created after the current table.
                if (index > i)
                {
                    cboReferenceTable.Items.Add(tables[i].TableName);
                }
            }
        }

        private void updateCboReferenceFieldList(Table table)
        {
            /*  This method updates the combo box for selecting the
             *  reference key for a foreign key
             */

            cboReferenceField.Items.Clear();
            for (int i = 0; i < table.Fields.Count; i++)
            {
                cboReferenceField.Items.Add(table.Fields[i].FieldName);
            }
        }

        private void cboReferenceTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  This method updates the cboReferenceField menu based on what the
             *  user selected in the cboReferenceTable.  The method is called when
             *  a user selects a new table in the cboReferenceTable
             *  The selected index is passed to the method that updates
             *  the cboReferenceField.
             */

            // The if statement is here to prevent exceptions if the SelectedIndex is null
            if (cboReferenceTable.SelectedIndex > -1)
            {
                updateCboReferenceFieldList(tables[cboReferenceTable.SelectedIndex]);
            }
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            /*  This method adds a field to the currently selected table's
             *  list of fields.  The field properties are determined by
             *  what the user has input.  This method is called when the
             *  user clicks the "Add Field" button.
             *
             * The following if blocks are used to check whether the user
             * has entered required and valid data into the inputs.
             */

            // if the field name is blank
            if (txtFieldName.Text == "")
            {
                MessageBox.Show("You need to enter a field name");
                txtFieldName.Focus();
                return;
            }

            // if the field name contains a space
            if (!txtFieldName.ToString().Contains(' '))
            {
                MessageBox.Show("A field name cannot contain spaces.");
                txtFieldName.Focus();
                return;
            }

            if (logicClass.fieldAlreadyExists(tables[index], txtFieldName.Text))
            {
                MessageBox.Show("The field name you entered is already in use in the table");
                txtFieldName.Focus();
                return;
            }

            // if a datatype is not selected
            if (cboDataType.SelectedItem == null)
            {
                MessageBox.Show("You need to enter a data type");
                cboDataType.Focus();
                return;
            }

            // if nullable is not selected
            if (cboNullable.SelectedItem == null)
            {
                MessageBox.Show("You need to specify whether the field is nullable or not");
                cboNullable.Focus();
                return;
            }

            // if primary key is not selected
            if (cboPrimaryKey.SelectedItem == null)
            {
                MessageBox.Show("You need to specify whether the field is a primary key or not");
                cboPrimaryKey.Focus();
                return;
            }

            // if unique is not selected
            if (cboUnique.SelectedItem == null)
            {
                MessageBox.Show("You need to specify whether the field has a unique constraint");
                cboUnique.Focus();
                return;
            }

            // if comments are not entered
            if (txtComments.Text == "")
            {
                MessageBox.Show("You need to enter a comment");
                txtComments.Focus();
                return;
            }

            string otherConstraints;
            // If a field is auto-increment, the data type must be INT
            if (cboOtherConstraints.SelectedItem != null)
            {
                if (cboOtherConstraints.SelectedItem.ToString() == "auto-increment")
                {
                    if (cboDataType.SelectedItem.ToString() != "INT")
                    {
                        MessageBox.Show("An auto-incremented field must also be of the INT datatype.");
                        return;
                    }
                }
                otherConstraints = cboOtherConstraints.SelectedItem.ToString();
            }
            else
            {
                otherConstraints = "";
            }

            string foreignKey = "";
            if (chkForeignKey.Checked == true)
            {
                if (cboReferenceTable.SelectedItem == null)
                {
                    MessageBox.Show("If the field is a foreign key, you have to enter a reference table.");
                    return;
                }
                else if (cboReferenceField.SelectedItem == null)
                {
                    MessageBox.Show("If the field is a foreign key, you have to enter a reference field.");
                    return;
                }
                foreignKey = cboReferenceTable.SelectedItem.ToString() + "." + cboReferenceField.SelectedItem.ToString();
            }
            /*  The following if-else blocks are used to convert string inputs ("Yes
             *  and "No") into boolean data types to pass to the Field constructor.
             */
            bool isNullable;
            bool isUnique;
            bool isPrimaryKey;

            if ((string)cboNullable.SelectedItem == "Yes")
            {
                isNullable = true;
            }
            else
            {
                isNullable = false;
            }
            if ((string)cboPrimaryKey.SelectedItem == "Yes")
            {
                isPrimaryKey = true;
            }
            else
            {
                isPrimaryKey = false;
            }
            if ((string)cboUnique.SelectedItem == "Yes")
            {
                isUnique = true;
            }
            else
            {
                isUnique = false;
            }

            // Creating a new Field object
            Field newField = new Field(txtFieldName.Text
                                        , (string)cboDataType.SelectedItem
                                        , isNullable
                                        , foreignKey
                                        , isPrimaryKey
                                        , isUnique
                                        , otherConstraints
                                        , txtComments.Text);

            // Adding the field to the selected table's list of fields
            table.AddField(newField);

            // closing the window
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
