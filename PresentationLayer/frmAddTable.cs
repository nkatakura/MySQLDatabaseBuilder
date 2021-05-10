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
    public partial class frmAddTable : Form
    {
        private List<Table> _tables;
        private LogicClass _logicClass;
        public frmAddTable(List<Table> tables, LogicClass logicClass)
        {
            InitializeComponent();
            _tables = tables;
            _logicClass = logicClass;
        }

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
            if (txtTableName.Text.Contains(' '))
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

            // The following if statement calls the tableAlreadyExists method
            // to check if the table name entered by the user has already been used.
            // Multiple tables cannot share the same MySQL table name.
            if (_logicClass.tableAlreadyExists(_tables, txtTableName.Text))
            {
                MessageBox.Show("The table name you entered is already in use.");
                txtTableName.Focus();
                return;
            }

            Table newTable = new Table(txtTableName.Text, txtTableDescription.Text);

            // Adding the created table to the list of tables
            _tables.Add(newTable);

            //  Closing the window
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
