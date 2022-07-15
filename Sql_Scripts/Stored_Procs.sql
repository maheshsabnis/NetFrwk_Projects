-- What are Stored Procedures (SP)?
	-- They are the Programmable Approaches to create an "excutable block of various
	-- Database valid stataments (Inbsert, Update, Delete, Select, etc.)"
	-- those will be "always compiled and reside in the Database Engine"
	-- Since its is in Pre-Compiled form the execution time will be faster as
	-- compare to raw Queries
-- Facts of SP
	-- They may or may-not have input and output parameters
	-- The Complex Database level logic can be written into SP e.g.
	-- If-else statements, Error Handling, etc.
	-- SP can return a complete recordset from table(s), or a single value, 
	-- or an error as per the logic
	-- SP encourages to write 100% database centric apps
-- Syntax
-- Create | Alter Procedure [NAME] (@Parameter1 Datatype,.....)
-- As
-- Begin
	-- LOGIC
-- End
-- Go (Complete the SP Body and execute it)

-- Execute Stored Proc
-- Exec [PROCEDURE-NAME] @Parameter,.... (if any)

-- Lets create a SP that will return all Employees

Create Procedure GetAllEmployees
As
Begin
	Select * from Employee;
End
Go
-- Lets Execute SP

Exec GetAllEmployees
Go

-- Stored Procedute with Input Parameter

Create Proc GetAllEmployeesByDeptNo
 -- Input Parameter
	@DeptNo int
As
Begin
	select * from Employee
	where DeptNo=@DeptNo;
End
Go
-- Execute the SP by passing Input Parameter
Exec GetAllEmployeesByDeptNo @DeptNo=40
Go

-- SP that return a single parameter

Create Proc GetSumSalaryByDeptNo
 -- Input Parameter 
	@DeptNo int	
As
-- Declare a Local Variable
Declare @SumSalary int; -- This is Not Output Parameter
Begin
	select @SumSalary = Sum(Salary) from Employee where DeptNo = @DeptNo;
	-- return statement
	return @SumSalary;
End
Go
-- Let's execute the SP with output value
-- 1. Declare a varible that will hold the return value from SP
Declare @SumSal int;
-- 2. Execute the SP and  Collect return value from it
Exec @SumSal = GetSumSalaryByDeptNo @DeptNo=30;
-- 3. Print the Result
Select @SumSal;
Go
-- A SP with Explicitly defined and passed output parameter

Create Proc sp_GetSumSalaryByDeptNoWithOutputParam
 -- Input Parameter 
	@DeptNo int, -- Input parameter
	@ResultandSum int Output -- Output parameter
As
-- Declare a Local Variable
Declare @SumSalary int; -- This is Not Output Parameter
Begin
	select @SumSalary = Sum(Salary) from Employee where DeptNo = @DeptNo;
	-- Set the value of the Local variable to output parameter 
	Select @ResultandSum = @SumSalary;
End
Go

-- Execute the SP with Outoptu Parameter
Declare @Result int;
-- Please make sure that the Output parameter name MUST be same while passing to the SP
Exec sp_GetSumSalaryByDeptNoWithOutputParam @DeptNo=10, @ResultandSum=@Result Output;
-- Print result
Select @Result;
Go;

-- Insert SP
Create proc sp_InsertDept
  @DeptNo int, @DeptName varchar(200), @Location varchar(200), @Capacity int
As
Begin
  -- Pass the column list while performign Insert operations
	insert into Department (DeptNo, DeptName, Location,Capacity)
	values
	-- Pass Parameters
	(@DeptNo, @DeptName, @Location, @Capacity);
End;
Go

-- Execute
Exec sp_InsertDept @DeptNo=70, @DeptName='Maintenence',@Location='Mumbai', @Capacity=3400;
Go

Select * from Department;
Go

-- Try..Catch Block
-- Begin Try...End Try ... Begin Catch ... End Catch
-- Error_Number() SQL Server Standard Function, this will Listen to the
-- Error Thrown by the SP
-- Error_Message() and Error_Severity() Standard functions


Create proc sp_InsertDeptWithErrrorHandling
  @DeptNo int, @DeptName varchar(200), @Location varchar(200), @Capacity int
As
Begin
   Begin Try
   
		insert into Department (DeptNo, DeptName, Location,Capacity)
		values
		(@DeptNo, @DeptName, @Location, @Capacity);
  End Try
  Begin Catch
  
	-- Catching the exception and sending it out from SP
	Select ERROR_NUMBER() as Error_Number,
		   ERROR_MESSAGE() as Error_Message,
		   ERROR_SEVERITY() as Error_Severity,
		   ERROR_STATE() as Error_State;
  End Catch
End;
Go

Exec sp_InsertDeptWithErrrorHandling @DeptNo=70, @DeptName='Maintenence',@Location='Mumbai', @Capacity=3400;
Go
-- Drop SP
Drop Proc sp_InsertDeptWithErrrorHandling;
Go
-- Using If-else Conditions

create Proc sp_GetEmpNoDeptNoIfElse
	@DeptNo int
As
Begin
  if @DeptNo <= 0
	select 'DeptNo cannot be 0 ot negative';
  else
	Select * from Employee
	where DeptNo=@DeptNo;
  	
End;
Go

exec sp_GetEmpNoDeptNoIfElse @DeptNo=0;
Go









