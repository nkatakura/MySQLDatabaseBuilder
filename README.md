PROJECT NAME:       MySQL Database Builder
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
	
USE STORIES:

        user adds a new table
        user deletes a table
        user selects an existing table
        user adds a field to the selected table
        user deletes a field
        user saves the current set of tables and fields to a file
        user loads a save of tables and fields into the program
        user builds an SQL file with currently created tables/fields


KNOWN ISSUES:

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

POSSIBLE FEATURES:

	    Add functionality for adding stored procedures to the SQL file
		    - automatically add CRUD stored procedures based on tables and fields OR
		    - let user decide which stored procedures to add

	    Allow users choose which file to save to

	    Allow users choose which file to load

	    Let users enter data into the tables they just created

        Allow users to edit existing tables and fields

        split user stories into separate windows for readability
