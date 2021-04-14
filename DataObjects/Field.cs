using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A field is a single piece of information from a record in a database.

namespace DataObjects
{
    public class Field
    {

        // Properties of a Field object:
        public string FieldName { get; set; }              // The name of the field
        public string DataType { get; set; }               // The datatype of the field (VARCHAR, INT, etc)
        public bool Nullable { get; set; }                 // Whether the field can be NULL in the database
        public string ForeignKey { get; set; }             // Whether the field is a foreign key, and what that key is (tablename.fieldname format)
        public bool PrimaryKey { get; set; }               // Whether the field is a primary key, or is part of the primary key
        public bool Unique { get; set; }                   // Whether the field has a unique contraint (true = has to be unique)
        public string OtherConstraints { get; set; }       // Any other constraints the field may have (auto-increment, etc)
        public string Comments { get; set; }               // Comments, or a description of the field

        // Constructor for Field objects:
        public Field(string fieldName, string dataType, bool nullable
                    , string foreignKey, bool primaryKey, bool unique
                    , string otherConstraints, string comments) 
        {
            FieldName = fieldName;
            DataType = dataType;
            Nullable = nullable;
            ForeignKey = foreignKey;
            PrimaryKey = primaryKey;
            Unique = unique;
            OtherConstraints = otherConstraints;
            Comments = comments;
        }
    }
}
