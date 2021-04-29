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

        github link: https://github.com/nkatakura/MySQLDatabaseBuilder
        
*/

/*  USER STORIES:
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
//  add validation for field names being the same

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
            InitializeComponent();
        }

        // Load event handler
        private void frmMain_Load(object sender, EventArgs e)
        {
            tables = new List<Table>();
            // _selectedFieldIndex = -1;
            // _selectedTableIndex = -1;
            logicClass = new LogicClass();

            try
            {
                tables = logicClass.LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error loading the save file.");
            }

            updateTableListDisplay(tables);
            _unsavedChangesExists = false;
        }

        // Event handler methods

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
                lblFieldComments.Text = tables[_selectedTableIndex].Fields[_selectedFieldIndex].Comments;
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
        private void mnuHowTo_Click(object sender, EventArgs e)
        {
            frmHowTo howTo = new frmHowTo();
            howTo.ShowDialog();
        }
        private void btnAddANewField_Click(object sender, EventArgs e)
        {
            if (lstTables.FocusedItem == null)
            {
                MessageBox.Show("You must select or add a table first");
                return;
            }
            frmAddField addField = new frmAddField(tables, _selectedTableIndex, logicClass);
            addField.ShowDialog();
            updateFieldListDisplay(tables[_selectedTableIndex].Fields);
        }
        private void btnAddANewTable_Click(object sender, EventArgs e)
        {
            frmAddTable addTable = new frmAddTable(tables, logicClass);
            addTable.ShowDialog();
            updateTableListDisplay(tables);
        }

        // Display update methods

        private void updateTableListDisplay(List<Table> tables)
        {
            //  This method updates the list of tables in the tables combo box.

            //  Clearing the current list
            lstTables.Items.Clear();
            lstFields.Items.Clear();

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
            }

            // Update the table description label
            lblTableDescription.Text = tables[_selectedTableIndex].TableDescription;
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