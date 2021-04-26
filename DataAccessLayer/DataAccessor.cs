using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace DataAccessLayer
{
    public class DataAccessor
    {
        // Properties of the DataAccessor class
        private string _dataPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);  // Sets the output path to the My Documents folder
        private const string _dataFolder = "\\MySQLBuilder\\";                                        // The output folder name
        private const string _dataFile = "savedata.tsv";                                              // The output file name
        
        // Constructor for a DataAccessor object:
        public DataAccessor()
        {
            string path = _dataPath + _dataFolder;
            try
            {
                if (Directory.Exists(path) == false)                // if the directory doesn't exist:
                {
                    Directory.CreateDirectory(path);                // this statement creates it
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("The output directory (" + _dataPath + _dataFolder + _dataFile + ") could not be created.", ex);
            }
        }
        public void SaveData(List<Table> tables)
        {
            //  This method saves the passed list of tables to a TSV file.
            try
            {
                StreamWriter fileWriter = new StreamWriter(_dataPath + _dataFolder + _dataFile);

                // This line of code prints the header row
                fileWriter.WriteLine("Table\tAttribute\tData Type\tNullable\tPK\tFK\tUnique\tOther Constraints\tComments");

                // Loop through the list of tables
                for (int i = 0; i < tables.Count; i++)
                {
                    /* In the data dictionary and in the TSV files that are read and written to, a table always has a table name
                     * as the first item, followed by 9 delimiters, and ends with the table description.  Each table loop begins
                     * by printing this line.
                    */
                    fileWriter.WriteLine(tables[i].TableName + "\t\t\t\t\t\t\t\t\t" + tables[i].TableDescription);

                    // Loop through the table's list of fields
                    for (int x = 0; x < tables[i].Fields.Count; x++)
                    {
                        /*  The if/else blocks in this section of the code are for converting the boolean properties
                         *  to strings to output onto the file.
                         */
                        string tableName = tables[i].TableName;
                        string fieldName = tables[i].Fields[x].FieldName;
                        string dataType = tables[i].Fields[x].DataType;
                        string nullable = "";
                        if (tables[i].Fields[x].Nullable)
                        {
                            nullable = "Y";
                        } else
                        {
                            nullable = "N";
                        }
                        string foreignKey = tables[i].Fields[x].ForeignKey;
                        string primaryKey = "";
                        if (tables[i].Fields[x].PrimaryKey)
                        {
                            primaryKey = "Y";
                        } else
                        {
                            primaryKey = "N";
                        }
                        string unique = "";
                        if (tables[i].Fields[x].Unique)
                        {
                            unique = "Y";
                        }
                        else
                        {
                            unique = "N";
                        }
                        string otherConstraints = tables[i].Fields[x].OtherConstraints;
                        string comments = tables[i].Fields[x].Comments;

                        //  Writing the line for the field onto the file:
                        fileWriter.WriteLine(tableName + "\t" + fieldName + "\t" + dataType + "\t" + 
                                             nullable + "\t" + primaryKey + "\t" + foreignKey + "\t" +
                                             unique + "\t" + otherConstraints + "\t" + comments);
                    }
                }
                fileWriter.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("There was an error writing data to the file", ex);
            }
        }
        public List<Table> LoadData()
        {
            /* This method retrives saved data by reading the TSV save file and returning a list of tables
             * The method works by reading each line, then splitting the line using a tab delimiter, then
             * storing the split line as a string array.  Because each index of the array corresponds to
             * a specific property of a field or table, converting the array into a field or table object is
             * straightforward.
             * 
             * Why TSV and not CSV?
             *      TSV files were easier to handle, as some of the datatype arguments (DECIMAL(6, 2), for
             *      example) contained commas.
             */
            Table currentTable = null;                  // Used to store the table currently being worked on in the file
            char separator = '\t';                      // Tab separator char
            string[] readLineAsArray;                   // Array to hold the different properties of a table or field
            List<Table> tables = new List<Table>();     // The list of tables to be built and returned
            try
            {
                StreamReader fileReader = new StreamReader(_dataPath + _dataFolder + _dataFile);
                while (fileReader.EndOfStream == false)
                {
                    string line = fileReader.ReadLine();            // Storing the read line
                    if (line.Length > 8)                            // Check to make sure the file or line actually contains what we want
                    {
                        readLineAsArray = line.Split(separator);    // Splitting and storing the read line as an array
                        if (readLineAsArray[0] != "Table")          // This if statement is here to skip the first header row
                        {
                            if (readLineAsArray[1] == "")           // If read line is for a table, the second string in the array will be empty
                            {
                                // If the read line is a table, create it and add it to the list of tables
                                currentTable = new Table(readLineAsArray[0], readLineAsArray[readLineAsArray.Length - 1]);
                                tables.Add(currentTable);
                            }
                            else                                    // If the second item is not empty, the line is for a field.
                            {
                                /*  The following series of lines store each individual item in its own variable.  This is to improve
                                 *  readability.
                                 *  The if/else blocks in the following section of the code is to convert string values from the save file
                                 *  to boolean values.
                                 */
                                string fieldName = readLineAsArray[1];
                                string dataType = readLineAsArray[2];
                                bool nullable;
                                if (readLineAsArray[3] == "Y" || readLineAsArray[3] == "y")
                                {
                                    nullable = true;
                                }
                                else
                                {
                                    nullable = false;
                                }
                                bool primaryKey;
                                if (readLineAsArray[4] == "Y" || readLineAsArray[4] == "y")
                                {
                                    primaryKey = true;
                                }
                                else
                                {
                                    primaryKey = false;
                                }
                                string foreignKey = readLineAsArray[5];
                                bool unique;
                                if (readLineAsArray[6] == "Y" || readLineAsArray[3] == "y")
                                {
                                    unique = true;
                                }
                                else
                                {
                                    unique = false;
                                }
                                string otherConstraints = readLineAsArray[7];
                                string comments = readLineAsArray[8];

                                // Creating the field object
                                Field field = new Field(fieldName, dataType, nullable, foreignKey, primaryKey, unique, otherConstraints, comments);

                                // Adding the field object to the current table's list of fields
                                currentTable.Fields.Add(field);
                            }
                        }
                    }
                }
                fileReader.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("There was an error loading the save file.\nPlease make sure there is a file to be loaded.\n" +
                                               "Save files are stored in the following directory: " + _dataPath + _dataFolder + _dataFile, ex);
            }
            return tables;
        }
        public void BuildSQL(List<Table> tables, string databaseName)
        {
            /*  This method builds the SQL script file based on the passed list of tables.
             *  The output file name is set to the databaseName.
             */
            string fileName = databaseName + ".sql";        // Adding the file extension to the filename
            try
            {
                StreamWriter fileWriter = new StreamWriter(_dataPath + _dataFolder + fileName);

                // Writing the sql code to drop / create the database
                fileWriter.WriteLine("DROP DATABASE IF EXISTS " + databaseName + ";");
                fileWriter.WriteLine("CREATE DATABASE " + databaseName + ";");
                fileWriter.WriteLine("USE " + databaseName + ";\n");

                for (int i = 0; i < tables.Count; i++)      // Loop for the list of tables
                {
                    //  Writing the Table header
                    fileWriter.WriteLine("/* *****************************************************************************\n" +
                                         "\tBuilding table " + tables[i].TableName +
                                         "\n* *****************************************************************************/\n");

                    //  Writing the drop / create for the table
                    fileWriter.WriteLine("DROP TABLE IF EXISTS " + tables[i].TableName + ";\n" +
                                         "CREATE TABLE " + tables[i].TableName + "(");

                    List<Field> fields = tables[i].Fields;          // Storing the currently selected table's list of fields

                    /*  The following lists of strings are used to store any of the table's primary and
                     *  foreign keys.  These are instantiated outside of the field loop because primary
                     *  and foreign keys have to be written after writing a table's list of fields.
                     */
                    List<string> primaryKeys = new List<string>();
                    List<string> foreignKeys = new List<string>();

                    for (int x = 0; x < fields.Count; x++)  // Loop for the list of fields
                    {
                        // Writing the line for each field
                        fileWriter.Write("\t" + fields[x].FieldName + " " + fields[x].DataType);

                        // if the field is nullable
                        if (fields[x].Nullable)
                        {
                            fileWriter.Write(" NULL");
                        } else
                        {
                            fileWriter.Write(" NOT NULL");
                        }

                        // if the field has to be unique
                        if (fields[x].Unique)
                        {
                            fileWriter.Write(" UNIQUE");
                        }

                        // if the field is an auto-increment
                        if (fields[x].OtherConstraints == "auto-increment")
                        {
                            fileWriter.Write(" AUTO_INCREMENT");
                        }

                        // escaping any apostrophes in the comments to prevent syntax errors
                        string fieldComment = fields[x].Comments.Replace("'", "''");

                        // writing the comment
                        fileWriter.WriteLine(" COMMENT '" + fieldComment + "'\t");

                        // If the field is a primary key, add it to the primary key list
                        if (fields[x].PrimaryKey)
                        {
                            primaryKeys.Add(fields[x].FieldName);
                        }

                        // If the field is a foreign key, add it to the foreign key list
                        if((fields[x].ForeignKey != ""))
                        {
                            foreignKeys.Add(fields[x].ForeignKey + "." + fields[x].FieldName);
                        }

                        // This if statement checks if the field is the last field in the list or not
                        // to decide whether to output a comma.
                        if(x != fields.Count - 1)
                        {
                            fileWriter.Write("\t,");
                        }
                    }

                    // If primary keys exist in the table, print them
                    if(primaryKeys.Count > 0)
                    {
                        fileWriter.Write("\t, PRIMARY KEY(");

                        // Loop for when there are multiple primary keys
                        for (int y = 0; y < primaryKeys.Count; y++)
                        {
                            fileWriter.Write(primaryKeys[y]);

                            // If statement to determine whether to print a comma for additional
                            // primary keys
                            if (y != primaryKeys.Count - 1)
                            {
                                fileWriter.Write(", ");
                            }
                        }
                        fileWriter.WriteLine(")");
                    }

                    // If foreign keys exist in the table, print them
                    if (foreignKeys.Count > 0)
                    {
                        /*  A foreign key's reference table and field are stored in the following format: ReferenceTable.ReferenceField
                         *  A . char delimiter is used to split the foreign key's reference into an array of two strings.  The 0 index
                         *  being the table name, and the 1 index being the field name.  These are then used to print the MySQL code.
                         */
                        char separator = '.';       // separator char
                        string fkReferenceTableName = "";         // string to hold the reference table name
                        string fkReferenceFieldName = "";         // string to hold the reference field name
                        string fkFieldName = "";                  // string to hold the field name

                        // loop through all foreign keys
                        for (int z = 0; z < foreignKeys.Count; z++)
                        {
                            // Split the string to an array
                            string[] fkTableNameAndFieldNameArray = foreignKeys[z].Split(separator);

                            // storing members of the array into strings (mostly for readability)

                            fkReferenceTableName = fkTableNameAndFieldNameArray[0];
                            fkReferenceFieldName = fkTableNameAndFieldNameArray[1];
                            fkFieldName = fkTableNameAndFieldNameArray[2];

                            // output
                            fileWriter.WriteLine("\t, CONSTRAINT fk_" + tables[i].TableName + "_" + fkReferenceTableName + "_" + fkReferenceFieldName);
                            fileWriter.WriteLine("\t\tFOREIGN KEY (" + fkFieldName + ") REFERENCES " + fkReferenceTableName + "(" + fkReferenceFieldName + ")");
                        }
                    }
                    
                    // outputting the table comment after looping through all fields
                    fileWriter.WriteLine(") COMMENT '" + tables[i].TableDescription + "'\n" +
                                         ";\n");
                }
                fileWriter.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}