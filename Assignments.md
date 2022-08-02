# Assignments
# Date: 07-July-2022

1. Use the following string
	- "Thor is a 2011 American superhero film based on the Marvel Comics character of the same name. Produced by Marvel Studios and distributed by Paramount Pictures,[N 1] it is the fourth film in the Marvel Cinematic Universe (MCU). It was directed by Kenneth Branagh, written by the writing team of Ashley Edward Miller and Zack Stentz along with Don Payne, and stars Chris Hemsworth as the title character alongside Natalie Portman, Tom Hiddleston, Stellan Skarsgård, Colm Feore, Ray Stevenson, Idris Elba, Kat Dennings, Rene Russo, and Anthony Hopkins. After reigniting a dormant war, Thor is banished from Asgard to Earth, stripped of his powers and his hammer Mjölnir. As his brother Loki (Hiddleston) plots to take the Asgardian throne, Thor must prove himself worthy."
	- Find out last occurance of 'a', 'e', 'i', 'o', 'u'
	- Find out count of 'and' in the string
2. Create a C# Program for Simple Math Operations with Data Types.       
	- Creae method for Add(x,y), Substr(x,y), Multi(x,y), Division(x,y), Square(x), SquareRoot(x), XRaisedToY(x,y), 
3. Accept input from the user and convert it to specific type.
	- Accept x and y from end-user
4. Use the Conditional Statement to validate inputs accepted from the user.
	- Make sure that x or y are not negative ot 0
5. Self-Study
	- What is 'ref', 'out', 'params' for method parameters in C#?
	- What is 'var' in C# for variable declarations
6. Explore the 'System.Math' class and try its methods	
	- e.g. Sin(), Cos(), Tan(), Abs(), Average(), etc.

# Date: 08-July-2022
1. Self-Study
	- Search, Understand and implement on
		- Multi-Dimentional Array
		- Jagged Array
2. Declare an array and insert data into the array by accepting data from user
3. Dynamically search data from array by accepting record to search from user
4. Open google.co.in and serach for James Bond int it. From the James Bond WiKi page copy first two paragrapg and save it in a variable. Perform Following operations on these paragraphs (Today)
	- Find out count of blanck spaces in the string
	- Find out count of words in the string
	- Find out count of statements in the string
	- Accept an input string from the user e.g. "the" and find out count of "the" in string and its positions
	- Find out count of vovels (a,e,i,o,u) in the string
	- Convert first character of each word in string into the uppercase
	- Print all special characters from the string.                                                           
5. Declare an ArrayList and add integers, characters, string, decimal, etc. values in it.
6. Perform following operations on the ArrayList
	- Add Record in specific index of the ArrayList
	- Remove Record at a specific Index
	- Read only strins from the collection   

# Date:12-July-2022

1. Varify the Following by Taking your own experience w.r.t. OOPs concepts (Implement First 5 problemem Statements Today)
	- Can we have Private and Protectd virtual methods in Abstract class?
	- If Yes, then with which access specifier should we use to overrride these method from derived class?
	- Can we have static members in abstract class?
	- Can the derived class be an abstract class?
	- Can we have abstract and virtual methods in non-abstract class?
	- Can we type-cast the derive class instance to base class?
	- Can sealed class contain Protected methods?
	- Can we have virtual or abtsract methods in sealed class?
	- Can the sealed class be a derived class?
	- Can we have static COnstructors in a class and if yes then how many times they are called and what will be the use of it?
	- Can we have static constructor and methods in Abstract class?
	- Can we have static constructor and methods in sealed class?
2. Complete the Assignment from the Applications folder with Following (MUST be completed by Thursday i.e. 14-July-2022)
	- Complete EmoployeeLogic class for CRUD operation
	- Create Classes derived from Employee for various designations as follows
		- Manager
			- ProjectAllowance
			- TravelAllowance
		- SalesManager Derived from Manager
			- PetrolAllowance
			- HotelAllowance
			- CustomExpenses
		- Engineer
			- OverTime
			- OverTimeHours
	- Calculate GrossSalary for each Emplyee	as
		- BasicSalary + Various Allowances as per the Designation
	- Calculate Tax for each Employee based on the GrossSalary as
		- 1Lac to 5 Lacs, 20% of GrossSalary
		- >5 Lacs to 10Lcs, 30% of GrossSalary
		- >10Lacs, 40% of GrossSalary
	- Calculate NetSalary as GorssSalary -  Tax
	- Print NetSalary in Words
	- Create an Accounts Class that will Calculate Salary for Each Employee

# Date:13-July-2022
1. Convert the Lab-4 of date 08-July-2022 for string operations by creating extension methods for 'string' class

# Date:15-july-2022
1. Create Category Table with CategoryRowId (identity), CategoryId varcharchar (Primary Key), CategoryName varchar.
2. Create Product Table with productRowId(Identity), ProductId varchar(Primary Key), ProductName varchar, Price int,ManufacturerName varchar, CategoryId (Foreign Key)
	- Note All Columns are Not Null
3. Insert Data in both table
4. Perform Following Operations on these tables
	- Create a Procedure that will accept CategoryName and all products of these category will be returned, The SP must check the CategoryName for not null and wheather it is present in Catefgory Table, if it is null or length is 0 or its is not present into the CategoryTable, return 'the CategoryName is invalid or not found' error message     

# Date: 18-July-2022

1. Complete all CRUD Operations for DepartmentDataAccess from 'Application.DataAccess' project and Complete Application.UI project by accessing The Application.DataAccess to complete all Operations usinbg Switch-Case
2. Repeate the for Employee Table
3. Self-Study	
	- Please find-out the number of SqlDataRedaers active at a time over a sinbgle DB Connection
	- Explore SqlBulkCopy Operations (Show on 21-July-2022)

# Date: 19-July-2022
1. Using the DLL approach for Entitie like Department and Employee clases and IDataAccess<TEntity, int TPk> aprroach for Data Access, perform CRUD Operations on Department And Employee Tables usinf Disconnected Architecture
	- A DLL for Employee and Department
	- A DLL for DataAccess for Department and Employee for Disconnected Architectire for CRUD Operations 
	- A Console App for Read/Write Operations using Switch Case by Accepting Data from End-User and Perform R/W operatrion using both DLLs referred into the Console Application

# Date: 22-July-2002
1. In ASP.NET Project add a Model Folder with following classes
	- State class with Properties as  StateId, StateName
	- States class derivbed from 
```` csharp		
		List<State>
````
		- HardCode the State names, in States class e.g. MH as Maharashtra, DL as Delhi, etc.	
	- City class with Porpeties as CityId, CityName, StateId
	- Cities class derived from
```` csharp
		List<City>
````
	- This class will have cities for States
2. Create a CascadeInfo.aspx web form in ASP.NEt Project and add asp:DropDownLists (DDL) each one for State and City
	- When a State is selected from States DDL, the Coity DDL will show all Cities from the selected state
	- (Optional) When the Page is loaded, for the First Selected 'State' in State DLL, show only Cities of that State

# Date: 25-July-2022 (try Using DI)
1. Update DepartmenbtDbAccess.aspx for Completing CRUD Operations for Department
2. Add a new EmployeeDbAccess.aspx for CRUD Operations
	- on this Page, show DropDownList for Department to select the DeptName to End-User and When the DeptName is selected, select the DeptNo for the Employee operatiosn (New/Update) 
3. Implement Validations for Both pages of 1 and 2
4. Create a Page named SearchEmpployees.aspx. This page will have DropDowns for Showing List of DeptNames, below this list add a GridView that will show all Employees. When a DeptName is selected, show only those Employees for the selected DeptName 

# Date: 26-July-2022
1. Create a Currency Converter User Control like Google Gives 
2. Refer the  HOL_2_UserControls_Custom_COntrols.pdf for Creating Custom Control

# Date: 27-July-2022

1. Modify the MVC_Application by adding Controller for Employee and Its CRUD Action methods with Views

# Date: 29-July-2022
1. Use the OnException() method of each controller class to Log Exception Details in Database
	- Create Table in Database of name 'Logger' with columns as 
		- LogId (Identity Key )
		- LogDate
		- ControllerName
		- ActionName
		- ExceptionDetails
	- Modify the Application.Entities by Adding a new class names 'Logger' with properties same as Logger Table and modify Application.DataAccess by adding  a new class for Adding the Log and retrieving log from MVC app 
# Date: 01-Aug-2022
- Complete the Update and Delete operations for REST APIs from ASP.NEt Web Form Client App
- Modify WEB API project by Adding EmployeeController for CRUD Operations on Employee Table 
- Access the EmployeeController using ASP.NET WebForm Client app by adding a new EmployeeRESTClient.aspx

# Date: 02-Aug-2022

1. Change the background color of table row to red when the mouse is enterd on it and once the mouse leave then get back to original 
	- Hint: .css('background-color', 'red') // add
			.css('') // remove
	- On the dynamically generated table row add  a click event and read all the tbale row values (values for each cell)	