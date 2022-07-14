Use UCompany;
-- Data Manipulation Statements
	-- Insert, Update and Delete

-- Insert records into the Department
Insert into Department Values (10, 'IT', 'Pune', 8000);
Insert into Department Values (20, 'HRD', 'Pune', 100);
Insert into Department Values (30, 'Accts', 'Pune', 500);
Insert into Department Values (40, 'Trag', 'Pune', 20);
Insert into Department Values (50, 'Support', 'Pune', 900);

-- Insert Records into Employee
insert into Employee Values (101, 'Mahesh', 'Director', 900000, 10);
insert into Employee Values (102, 'Tejas', 'Director', 900000, 20);
insert into Employee Values (103, 'Ramesh', 'Director', 900000, 30);
insert into Employee Values (104, 'Sharad', 'Director', 900000, 40);
insert into Employee Values (105, 'Sanjay', 'Director', 900000, 50);
insert into Employee Values (106, 'Vijay', 'Manager', 900000, 10);
insert into Employee Values (107, 'Vilas', 'Manager', 900000, 20);
insert into Employee Values (108, 'Abhay', 'Manager', 900000, 30);
insert into Employee Values (109, 'Vivek', 'Manager', 900000, 40);
insert into Employee Values (110, 'Satish', 'Manager', 900000, 50);
insert into Employee Values (111, 'Mukesh', 'Lead', 900000, 10);
insert into Employee Values (112, 'Sandeep', 'Lead', 900000, 20);
insert into Employee Values (113, 'Vinay', 'Lead', 900000, 30);
insert into Employee Values (114, 'Kaustubh', 'Lead', 900000, 40);
insert into Employee Values (115, 'Tushar', 'Lead', 900000, 50);
insert into Employee Values (116, 'Krishna', 'Associate', 900000, 10);
insert into Employee Values (117, 'Arav', 'Associate', 900000, 20);
insert into Employee Values (118, 'Nainesh', 'Associate', 900000, 30);
insert into Employee Values (119, 'Aditya', 'Associate', 900000, 40);
insert into Employee Values (120, 'Sujay', 'Associate', 900000, 50);

select * from Employee;

-- Lets Update
-- Update [Table Name] Set [column]=New-Value,[column]=new value..... Where [Condition]
Update Employee Set Salary = 700000 where Designation='Manager'; 

Update Employee Set Salary = 500000 where Designation='Lead'; 

Update Employee Set Salary = 400000 where Designation='Associate';

-- Lets Delete
-- Delete [Table-Name] Where [Condition]
-- Delete Records based on Condition
Delete Employee Where Designation='Associate';

-- Delete all Records from the table and Refresh it 
--(Too Dangerous, use it carefully because this is Data loss)

Truncate table Employee;