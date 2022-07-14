Use UCompany;

-- List of all Employees
select * from Employee;

-- List of Employees by DeptNo
select * from Employee where DeptNo=10;
-- List of all Employee Having EmpName Starts from 'M'
select * from Employee Where EmpName Like 'M%'; 
-- Reading Employee only in specific DeptNos e.g. 10,30,50
-- Use the 'IN'  Operator
select * from Employee where DeptNo In (10,30,50);
select * from Employee Where DeptNo = 10 or DeptNo=30 or DeptNo=50;
-- Read Limitted Records from the table using Limit Operators
-- top(),
select top(4) * from Employee;
-- Read all Employees Having Salary between ragne of 300000 to 500000
select * from Employee where Salary Between 300000 AND 500000; 

-- Print all Employee Order by EmpName in Ascending Order (Default)
select * from Employee Order by EmpName;  
-- Print all Employee Order by EmpName in Descending Order 
select * from Employee Order by EmpName desc;  
-- Select Sum of Salary by DeptNo
-- Agreegate Functions from SQL
-- sum(), count(), min(), max(), etc.
-- Sum of salary based on specific DeptNo
Select Sum(Salary) from Employee Where DeptNo=20;
-- Sum of salary group by DeptNo
select DeptNo, Sum(Salary) as Salary from Employee Group by DeptNo;
-- Read the Second Max Salary form Employee
select Max(Salary) as Salary from Employee  
where Salary < (Select Max(Salary) From Employee);

select * from Employee;
-- Second Max for Each Dept
select DeptNo, Max(Salary) as Salary from Employee  
where Salary < (Select Max(Salary) From Employee)  group by DeptNo;




