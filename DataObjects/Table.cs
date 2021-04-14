using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Table
    {
        // Properties of a Table object:
        public string TableName { get; set; }                  // The name of the table
        public string TableDescription { get; set; }           // The description of the table
        public List<Field> Fields { get; set; }                // The list of fields that belongs to the table

        // Constructor for table objects:
        public Table(string tableName, string tableDescription)
        {
            TableName = tableName;
            TableDescription = tableDescription;
            Fields = new List<Field>();
        }

        // The AddField method adds a field to the table's list of fields
        public void AddField(Field field)
        { 
            // Adds a field to a table's list of fields
            Fields.Add(field);
        }
    }
}