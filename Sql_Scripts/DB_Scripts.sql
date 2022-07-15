-- Create Database
Create Database UCompany;
-- Delete Database
Drop Database UCompany;

-- Set the UCompany database as a current database for use
Use UCompany;

-- Create a Table
Create Table Department (
   DeptNo int Primary Key,
   DeptName  varchar(200),
   Location varchar(100)
);

-- Alter the table for Settings Constraints as Not Null
Alter Table Department alter Column DeptName varchar(200) Not Null; 
Alter Table Department alter Column Location varchar(200) Not Null; 

-- Add Column into the table (With Mis-Spelling)
Alter Table Department Add  Capcity int not null;

-- Rename the Column using the System Stored Procedure sp_rename
-- Execute the System Stored Proc to rename the column
Exec sp_rename 'Department.Capcity', 'Capacity';

-- Adding a child table for Depratment
-- One-to-Many i.e. One Department Can have Multiple Employees
-- because of the Foreign Key
-- One-to-One, One Employee can have 'Only-One' Department

-- Foreign-Key: Used for Referntial Integrity, means when insert/update takes place into the
-- Employee table (Child-table), the value passed for the Foreign-Key column (here DeptNo) will
-- be verified into the Department Table(Parent-Table)

Create Table Employee(
  EmpNo int Primary Key,
  EmpName varchar(400) Not Null,
  Designation varchar(100) Not Null,
  Salary int Not Null,
  DeptNo int Not null References Department(DeptNo) -- Syntax for Foreign Key
);



-- Remove the column but make sure that it is not a Constraint Column
-- e.g. Primary Key Foreign Key
Alter Table Employee Drop Column Designation;

-- Drop The Table, Make sure that this table is not having any child table
-- Means the Primary Key of Table Being Dropped MUST not be used as Foreign Key 
-- in Any other table using 'references'
Drop table Employee;

-- Table with Auto-Increment value
Create Table Error_Logger (
   Error_Id int Identity (1,1) Primary Key,
   Error_Number int not null,
   Error_Message varchar(6000) Not Null,
   Error_Severity int not null,
   Error_State int not null
);

 Drop Table Error_Logger;