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

/*  PROJECT NAME:       MySQL Database Builder
    PROJECT AUTHOR:     Naoki Katakura
    PROJECT DESCRIPTION:
		The main purpose of this program is to generate a MySQL script file that builds a database
        that a user created.  Databases can be designed by manually inputting tables and fields
        into the GUI, or by loading a data dictionary in the form of a TSV file.

        There are two main data objects in use: Tables and Fields.  Like a database, a table
        object owns a list of fields.

        This project was created to fulfill the final project requirement for my .NET I course
        at Kirkwood Community College (Spring 2021 with Jim Glasgow).
        The course was taken as part of the AAS Computer Software
        Development degree program.
*/

/*  USE STORIES:
        user adds a new table
        user deletes a table
        user selects an existing table
        user adds a field to the selected table
        user deletes a field
        user saves the current set of tables and fields to a file
        user loads a save of tables and fields into the program
        user builds an SQL file with currently created tables/fields
*/

/*  KNOWN ISSUES:
        Importing from a TSV file created using a spreadsheet program like Google Sheets or Microsoft Excel
        requires VERY specific formatting.  Validating imported data or adding flexibility to importing data
        will reduce errors.

        There is no way to give table-specific names to foreign keys. Foreign key names are set to the key
        they are referencing.  Giving the users an option to name foreign keys will improve usability.
        This means that in the data dictionary a user creates, any foreign keys have to be named the same
        as the key they are referencing.  This is a pretty big issue when creating a database, so this would
        be one of the first things to fix in a later version.

        In MySQL, table and field names cannot be MySQL keywords.  There is no validation in the current
        version of the software to prevent a user from making table and field names MySQL keywords.
        Adding this validation will reduce errors in the generated MySQL code.

        For the VARCHAR, DECIMAL, and ENUM MySQL data types, the arguments are hard coded.  Allowing
        users to add custom arguments will improve flexibility.
*/

/*  POSSIBLE FEATURES:
	    Add functionality for adding stored procedures to the SQL file
		    - automatically add CRUD stored procedures based on tables and fields OR
		    - let user decide which stored procedures to add

	    Allow users choose which file to save to

	    Allow users choose which file to load

	    Let users enter data into the tables they just created

        Allow users to edit existing tables and fields

        split user stories into separate windows for readability
 */

//WORK FLOW:
//      validate auto-increment fields are also of the INT data type
// validation:
//      multiple tables cannot share the same table name
//  	make a load event handler and move stuff there

namespace PresentationLayer
{
    public partial class frmMain : Form
    {
        private List<Table> tables;             // List of tables to be passed around
        private LogicClass logicClass;          // Logic Class object
        private int _selectedTableIndex;        // int variable that stores the selected table index
        private int _selectedFieldIndex;        // int variable that stores the selected field index
        private bool _unsavedChangesExists;     // bool that is switched to true/false based on if the user has unsaved changes
        public frmMain()
        {
            tables = new List<Table>();
            // _selectedFieldIndex = -1;
            // _selectedTableIndex = -1;
            logicClass = new LogicClass();
            InitializeComponent();
            tables = logicClass.LoadData();
            updateTableListDisplay(tables);
            _unsavedChangesExists = false;
        }

        // Event handler methods

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            /*  This method creates a new Table object and adds it to the
             *  program's list of Tables based on the user's inputs. This
             *  method is called when the user clicks the "Add Table" button
             */

            // The following if statement checks if the user has entered
            // a table name.
            if (txtTableName.Text == "")
            {
                MessageBox.Show("You need to enter a table name");
                txtTableName.Focus();
                return;
            }

            // The following if statement checks if the user entered a table name containing a space
            if (!txtTableName.ToString().Trim().Contains(' '))
            {
                MessageBox.Show("Table names cannot contain spaces");
                txtTableName.Focus();
                return;
            }

            // The following if statement checks if the user has entered a table
            // description.
            if (txtTableDescription.Text == "")
            {
                MessageBox.Show("You need to enter a table description");
                txtTableDescription.Focus();
                return;
            }

            Table newTable = new Table(txtTableName.Text, txtTableDescription.Text);

            // The following if statement creates a new list of tables if one does
            // not exist yet
            if (tables == null)
            {
                tables = new List<Table>();
            }

            tables.Add(newTable);

            // Clearing controls
            txtTableName.Clear();
            txtTableDescription.Clear();
            txtTableName.Focus();

            // Calling the method to update the visible list of tables
            updateTableListDisplay(tables);
            _unsavedChangesExists = true;
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

            // if a table is not selected
            if (lstTables.FocusedItem == null)
            {
                MessageBox.Show("You must select or add a table first");
                return;
            }

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
                MessageBox.Show("A fieldname cannot contain spaces.");
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
            if(cboOtherConstraints.SelectedItem != null)
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
            } else
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
            tables[_selectedTableIndex].AddField(newField);

            // Updating the field list display on the program.
            updateFieldListDisplay(tables[_selectedTableIndex].Fields);

            // Clearing controls
            txtFieldName.Clear();
            cboDataType.SelectedItem = null;
            cboNullable.SelectedItem = null;
            cboPrimaryKey.SelectedItem = null;
            cboUnique.SelectedItem = null;
            chkForeignKey.Checked = false;
            cboReferenceField.SelectedItem = null;
            cboReferenceTable.SelectedItem = null;
            txtComments.Clear();
            cboOtherConstraints.SelectedItem = null;

            _unsavedChangesExists = true;
        }
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            /*  This method deletes the selected table from the list of tables.
             *  This method is called when the user clicks the "delete table"
             *  button.
             */

            // if block to check if an item is selected
            if (lstTables.FocusedItem == null)
            {
                MessageBox.Show("You must select a table to delete");
                return;
            }

            // if block to ask the user to confirm deletion.
            if (MessageBox.Show("Are you sure you want to delete the selected table?\nThis cannot be undone.", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // remove and update table
            tables.RemoveAt(_selectedTableIndex);
            updateTableListDisplay(tables);

            // clear the field display
            lstFields.Items.Clear();

            _unsavedChangesExists = true;
        }
        private void btnDeleteField_Click(object sender, EventArgs e)
        {
            /*  This method deletes a field from a table's list of fields based on 
             *  the selected table and field.
             */

            // if block to check if the user has chosen a field
            if (lstFields.FocusedItem == null)
            {
                MessageBox.Show("You have to select a field to delete.");
                return;
            }

            // if block to confirm deletion
            if (MessageBox.Show("Are you sure you want to delete the selected field?\nThis cannot be undone.", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // remove selected field from selected table
            tables[_selectedTableIndex].Fields.RemoveAt(_selectedFieldIndex);

            // refresh the display
            updateFieldListDisplay(tables[_selectedTableIndex].Fields);

            _unsavedChangesExists = true;
        }
        private void lstTables_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            /*  This method updates the field list box display when a user selects a new
             *  table from the table list box.  The selected table index is stored in 
             *  a variable which is used to pass the field list into the field display.
             */

            // This if statement is here to prevent crashes
            if (lstTables.SelectedItems != null && lstTables.SelectedItems.Count > 0)
            {
                _selectedTableIndex = lstTables.FocusedItem.Index;
                updateFieldListDisplay(tables[_selectedTableIndex].Fields);
            }

            // clearing foreign key field controls
            chkForeignKey.Checked = false;
            cboReferenceField.Items.Clear();
            cboReferenceTable.Items.Clear();
        }
        private void lstFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  This event handler method updates the selected field index variable
             *  The variable is used if the user clicks the "delete field" button.
             *  The _selectedFieldIndex variable is then used in the btnDeleteField
             *  button click action listener.
             */
            if (lstFields.SelectedItems != null && lstFields.SelectedItems.Count > 0)
            {
                _selectedFieldIndex = lstFields.FocusedItem.Index;
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
            if(cboReferenceTable.SelectedIndex > -1)
            {
                updateCboReferenceFieldList(tables[cboReferenceTable.SelectedIndex]);
            }
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
                updateCboReferenceTableList(tables);
            }
            else
            {
                cboReferenceTable.Enabled = false;
                cboReferenceField.Enabled = false;
            }
        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            /*  This event handler is called when the user clicks the "exit" button.
             *  The user is warned if there is any unsaved data.
             */

            if (_unsavedChangesExists)
            {
                if(MessageBox.Show("You have unsaved changes.  These will be lost when exiting." +
                                   "Are you sure you want to exit?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                } else
                {
                    this.Close();
                }
            } else
            {
                this.Close();
            }
        }

        // Display update methods

        private void updateTableListDisplay(List<Table> tables)
        {
            //  This method updates the list of tables in the tables combo box.

            //  Clearing the current list
            lstTables.Items.Clear();

            //  Loop through the list of tables and adds each tablename to the
            //  combo box's list of items.
            for (int i = 0; i < tables.Count; i++)
            {
                lstTables.Items.Add(tables[i].TableName);
            }
        }
        private void updateFieldListDisplay(List<Field> fields)
        {
            /*  This method updates the display to show the list of
             *  fields that is passed as an argument.
             */

            // Clearing the current display
            lstFields.Items.Clear();

            // Loop for each item in the field list
            for (int i = 0; i < fields.Count; i++)
            {
                // Adding field name to display
                lstFields.Items.Add(fields[i].FieldName);

                /* Adding other properties to the display as subitems.
                 * if-else blocks are used to determine whether to display "Y" or "N"
                 * based on if the user entered "Yes" or "No"
                 */
                lstFields.Items[i].SubItems.Add(fields[i].DataType);
                if (fields[i].Nullable)
                {
                    lstFields.Items[i].SubItems.Add("Y");
                }
                else
                {
                    lstFields.Items[i].SubItems.Add("N");
                }
                lstFields.Items[i].SubItems.Add(fields[i].ForeignKey);
                if (fields[i].PrimaryKey)
                {
                    lstFields.Items[i].SubItems.Add("Y");
                }
                else
                {
                    lstFields.Items[i].SubItems.Add("N");
                }
                if (fields[i].Unique)
                {
                    lstFields.Items[i].SubItems.Add("Y");
                }
                else
                {
                    lstFields.Items[i].SubItems.Add("N");
                }
                lstFields.Items[i].SubItems.Add(fields[i].OtherConstraints);
                lstFields.Items[i].SubItems.Add(fields[i].Comments);
            }

            // Update the table description label
            lblTableDescription.Text = tables[_selectedTableIndex].TableDescription;
        }
        private void updateCboReferenceTableList(List<Table> tables)
        {
            /*  This method updates the combobox for choosing a reference table on a
             *  foreign key.
             */
            cboReferenceTable.Items.Clear();
            for (int i = 0; i < tables.Count; i++)
            {

                // This if statement is here because you cannot add foreign key references
                // from tables that are created after the current table.
                if (_selectedTableIndex > i)
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

        // File access methods

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            /*  This method is used to load data from the save file
             *  It is called when the user clicks the "Load Data" button
             *  or the "Load TSV File" button from the menu strip.
             */

            try
            {
                tables = logicClass.LoadData();
                updateTableListDisplay(tables);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            /*  This method is used to save data to the save file.
             *  It is called when the user clicks the "Save Data" button
             *  or the "Save TSV File" button from the menu strip.
             */

            if (tables.Count == 0)
            {
                MessageBox.Show("There is no data to save.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool result = false;
            try
            {
                result = logicClass.SaveData(tables);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n(" + ex.InnerException.Message + ")", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (result)
            {
                MessageBox.Show("Data save successful.", "", MessageBoxButtons.OK);
            }

            _unsavedChangesExists = false;
        }
        private void btnBuildSQL_Click(object sender, EventArgs e)
        {
            /*  This method is called to build the MySQL script file.
             *  It is called when the user clicks the "Build SQL" button.
             */

            if (txtDatabaseName.Text == "")         // Input validation
            {
                MessageBox.Show("You have to enter a database name");
                txtDatabaseName.Focus();
                return;
            }
            if(txtDatabaseName.Text.Contains(' '))  // Input validation
            {
                MessageBox.Show("Database name cannot contain spaces.");
                txtDatabaseName.Focus();
                return;
            }
            string databaseName = txtDatabaseName.Text;
            try
            {
                bool result = logicClass.BuildSQL(tables, databaseName);
                if (result)
                {
                    MessageBox.Show("SQL built successfully", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n(" + ex.InnerException.Message + ")", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mnuLoadTSV_Click(object sender, EventArgs e)
        {
            //Event handler for the menu strip button "Load TSV File".
            btnLoadData_Click(sender, e);
        }
        private void mnuSaveCSVFile_Click(object sender, EventArgs e)
        {
            // Event handler for the menu strip button "Load TSV File".
            btnSaveData_Click(sender, e);
        }
    }
}