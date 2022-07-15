-- What are triggers?
-- They are an internal events those are activated and raised
-- When the Table they are monitoring is Inserted, Updated, Seleted

Create Table DepartmentAudit(
   AuditId int identity(1,1) Primary Key,
   AuditedDeptNo int not null,
   AuditDate Date Not null
);
Go
-- Create a Trigger
-- Before | After Insert Update Delete

Create Trigger trigger_InsertDepartment
On Department -- Table Name to which the trigger will monitor
After Insert -- the condition for trigger to activate After Update After Delete
As
Begin
	-- 1. Extract the DeptNo Which is Inserted into Department Table
	Declare @DeptNo int;	   -- Updated Deleted 	
	Select @DeptNo=DeptNo from Inserted -- DeptNo will be received from Insert Statement
	-- Insert a new record into the DepartmentAudit Table
	Insert into DepartmentAudit
	Values
	(			
	  @DeptNo, GETDATE() -- a Standard SQL FUnction
	);
End
Go


-- Insert new Record into Department Table
Exec sp_InsertDept @DeptNo=80, @DeptName='Hardware',@Location='Pune', @Capacity=30;
Go


Select * from DepartmentAudit;