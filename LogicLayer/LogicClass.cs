using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicClass
    {
        public LogicClass()
        {

        }
        public bool foreignKeyExists(List<Table> tables, string foreignKey)
        {
            // This method checks whether the foreign key argument exists in any tables
            // in the table list.
            bool exists = false;                                                // Boolean variable to store whether the field exists
            char[] separator = { '.' };                                         // Separator character to separate a table name and field name
            int matchingTableIndex;                                                     // A variable to store a table index
            string[] tableAndFieldName = foreignKey.Split(separator);           // String array to hold the table name and field name separately
            string tableName = tableAndFieldName[0];                            // Store the first value in the string array as the table name
            string fieldName = "";                                              // String to store the name of the field
            // Try/Catch block to catch an out-of-bounds exception in case an invalid format is inputted
            try
            {
                fieldName = tableAndFieldName[1];                               // Store the second value in the string array as the field name
            }
            catch (Exception)
            {
                throw;
            }

            for (int i = 0; i < tables.Count; i++)                              // A loop that iterates over all tables
            {
                if (tables[i].TableName == tableName)                           // If block that checks if the tablename from the argument matches the tablename of the currently selected table
                {
                    matchingTableIndex = i;                                     // Storing the table index that matches the tablename argument
                    for (int x = 0; x < tables[i].Fields.Count; x++)            // For loop to iterate over all fields in the selected table
                    {
                        if (tables[i].Fields[x].FieldName == fieldName)         // If block that checks it the fieldname from the argument matches a fieldname in the currently selected table
                        {
                            if (tables[i].Fields[x].PrimaryKey)                 // If block to check if that field is the primary key of the table
                            {
                                exists = true;
                            }
                        }
                    }
                }
            }

            return exists;
        }
        public bool SaveData(List<Table> tables)
        {
            // Method called to save data.  Calls the SaveData method in the DataAccessor class
            bool result = false;
            try
            {
                DataAccessor dataAccessor = new DataAccessor();
                dataAccessor.SaveData(tables);
                result = true;
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }
        public bool BuildSQL(List<Table> tables, string databaseName)
        {
            // Method called to build the MySQL file.  Calls the BuildSQL method in the DataAccessor class

            bool result = false;
            try
            {
                DataAccessor dataAccessor = new DataAccessor();
                dataAccessor.BuildSQL(tables, databaseName);
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public List<Table> LoadData()
        {
            // Method called to load data.  Calls the LoadData method in the DataAccessor class

            List<Table> tables;
            try
            {
                DataAccessor dataAccessor = new DataAccessor();
                tables = dataAccessor.LoadData();
            }
            catch (Exception ex)
            {
                throw;
            }
            return tables;
        }
    }
}
