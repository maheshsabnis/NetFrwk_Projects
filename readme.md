# .NET Framework Application Development

# C# Programming

1. Data Types and Keywords

Data Type		Keyword			Type Name (.NET Structure)			Size in Bytes

Integer			byte			System.Byte							1
				short			System.Int16						2
				ushort			System.UInt16						2
				int				System.Int32						4
				uint			System.UInt32						4
				long			System.Int64						8
				ulong			System.UInt64						8

Floating Point
				float			System.Float32						4
				double			System.Float64						8

Decimal
				decimal			System.Decimal						2 raised to 16

Character	
				char			System.Char							2

String
				string			System.String						Reference Type

Date
				datetime		System.DateTime						10
Boolean
				bool			System.Boolean						

What is System?
	- Highest level namespace in .NET
	- Its a Group of classes, structure with Similar funcationality
	- A namespace can have child namespace in it
	- Each Project has a namespace same as the name of the project
		- All classes in the that project will be part of that namespace

2. Input and Output Statements
	- System.Console is the standard class fdrom .NET Frwk used for input and output
		- Console.WriteLine()
			- The Output Statement Method
			- Used to present data to the End-User
		- Console.ReadLine()
			- The Input Statement Method
			- This is used to Accept data from End-User
			- This always returns 'string'	
3. Conditional Statements
	- if, if..else,
	- switch..case
4. Operators
	- +,-,*,/
	- The '+' is by default overloaded for string concatenation if both operands are string types
		- e.g.
			- if a and b astring then a + b will concatenate string 
	- +=, -=, ++, --
	- >, <, >=, <=, !=, == (comparision)
	- ! (Not)m || (OR), && (AND)
	- Conditional Operators
		- if(a > b) { return x; } else { return y;}
		- Replace above statement with following
			- a > b ? x : y;
				- ? will evaluate the condition, if its is true then x else y
5. Convertions
	- Used to covert the Data from one type to other
	- The 'System.Convert' class
		- Convert.ToInt32(STRING)
			- Merthod convert the numeric data received as STRING to integer
			- e.g.
				- Convert.ToInt32("1000");
					- The "1000" is string thet will be converted and returned as integer 1000
		- ToString()
		- ToBoolean()
		- ToDecimal()
		- ToFloat()
		- ... an so on		
	- int.parse()
		- Parse the string into integer
		- Avoid using it
6. Version
	- Major.Minor.BuildNumber.Revision
	- 1.2.3.4
	- Each .NET Application has version
7. Project references
	- Conatisn List of Stranard as well as Custom Libraries used by the Current Project
8. Using the Visual Studio Features for Debugging the code
	- F9 key to apply breakpoints, the execution will be broken from this line onwards
	- F5, to run the application
	- F11, to debug each line for each method in the code with method call
	- F10, debug each line but do not jump to method call for debugging
9. Divide the code into seperate functions /  methods
	- A method is gorup of statements which are execute repetedly when the method is called
	- A method can have input parameter as well as output parameters
	- If a method does not return anything then use 'void' as return from method
	- Input parameters to a method are known as 'formal-parameters'
10. Working with integer values
	- integer /  interger is always integer, so if you want ot receive the correct mathematical result, the type-cast the division of ingegers and store result into the double
		- double res = Convert.ToDouble(x,y);
			- Here x and y are integers
	- integer * integer many not always within the limit of integer
		- Note: Make sure that the result is stored either in long or decimal type 
11. Using Strings
	- String is a reference type, a class that contains methods for string operations
12. Concept of .NET Types
	- System.Type class
		- Defining the mechanism for storing data in Memory (Managed-Heap) in well define format as follows
			- The DataType of the value
			- The Actual Value
	- System.Object
		- The Highest-Level Type in .NET
		- The 'object' a keyword
		- Each Data Types (Standard or user defined) can be represented as object
	- Boxing and UnBoxing
		- Storing value type into reference type is Boxing
			- e.g.
				- int i = 10;
				- object obj = i; 
		- Retrieving value type from reference type is UnBoxing, make sure that the type of data stored in object must be known 
			- e.g.
				- int j = (int)o; 
NOTE: ONCE A VARIABLE IS DECLARED (PRIMTIVE OR CUSTOM STYPE), PLEASE SET SOME INITIAL VALUE FOR IT
	- FOR REFERENCE TYPES YOU CAN PROIVE INTIAL VALUE AS 'null' BUT THEN MAKE SURE THAT WHILE EXECUTING THE CODE, THE REFERENCE TYPE HAS SOME 'DEFINIT DATA IN IT' OTHERWISE APP WILL CRASH WHILE EXECUTING  
13. The Collections
	- The appliaction needs to store Huge amount of data so that it can be processed, shared across various applications
	- To Add or precess data from Collections using Loops
		- for..loop
			- for(counter; counter condition against length of recocrds; counter increament)
				{
				}
		- foreach..loop
			- Recommended fro Collections
			- foreach(record in collection)
			  {
				  PROCESS
			  }
		- while..loop
		- do..while
	- The 'Array'
		- Language Agonostic mechanism of storing large data
		- System.Array class
			- When the array is defined using following syntax
				- DATA-TYPE [] IDENTIFIER;
				- e.g.
					- int [] arr;
				- It will become an instance of System.Array by default 
	- Collections are standard Classes used to store huge data in it
		- There is no limit for storing data in array
		- Each Entry in collection is stored as an 'object'
			- The Collection 'Boxes' the data while storing the data in it
			- This means that the while retrieving data from collecction the 'Unboxing' must be used
		- System.Collection Namespace
			- ArrayList
			- Stack
			- Queue
			- LinkedList
			- ... etc
	- Generic Collections
		- Collections based on Concept of Generics introduced in .NET Frwk 2.0
		- Generics (Templates in C++)
			- A Type-Safe Arrangement of data stored for .NET Apps
			- The Type of data that is to be stored in collection will be informed to .NET Frawk at Compile time
			- For the  collection type seperate copies of the same collection for different data types will be created in binary form in memory for Binary re-usability
			- e.g.
				- List<T>, the generic List class
				- List<int>, list will have only 'integers'
				- List<string>, list will have only string
				- Hence No Boxing anmd UnBoxing
		- System.Collections.Generics namespace
			- List<T>, Stack<T>, Queue<T>, LinkedList<T>
				- The 'T' is s templatre parameter that will be set to premtive data type or custom datatype
			- Key Value Pairs
				- Dictionary<K,V>
					- K and V are 'T' only
		- We Can have Generic
			- Classes
			- Methods
			- Interfaces
			- Variables
			- Events
			- Delegates
14. .NET Application Execution
	- APplication Compilation
		- Comman Language Specification (CLS), using Common Type System (CTS) and Framework Class Library (FCL)
			- The FCL is referred using 'mscorlib.dll'
	- Check what application template is under Compilation
		- .Exe compiled output
			- Console Apps, WinfoForms, Windows Service
		- .dll
			- Class Library Project, ASP.NET WebForms, MVC, Web API
	- The Compiled output (.exe/.dll) is called as 'Assembly' 
	- Assembly
		- Successful Compiled Output from .NET Apps
			- This contains all namespace(s) (and hence all classes from the project) 
		- Unit for Execution (Deployment)
		- We use the assembly for application (aks Code) sharing to client apps in case of .dll assemblies
		- Technically
			- It is following
				- Intermidiate Code (IL) or MSIL
					- Source-Code Compilation into intermidiate code format
					- This is common for all .NET Language
				- Assembly Info aka Manifest
					- Name
					- Version
					- Copyright
					- ... etc
				- Metadata
					- What are the dependencies used by the assembly
					- e.g.
						- Some externally referreed assemblies
			- Use 'ildasm.exe' tool to view the assembly
				- C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\ildasm.exe

# C# Object Oriented Programming

1. Class
	- Keyword as 'class'
	- Class Contains Following
		- Data Members
		- Member Functions aka Methods
		- C# for all .NET Languages
			- Events
			- Properties
	- Access Specifiers
		- private, default for each class member of the class, accessible only in the declaring class
		- public, accessible everywhere
		- protected, accessible in declaring class and derived class of the declaring class
		- C# 
			- internal, accessible in each class of the the namespace of the declaring class
			- protected internal, like 'internal' but the accessibilty is also possible in the derived class of the different namespace
				- e.g.
					- Class A in namespace N1 conatins m1() as 'protected internal' method
					- Class B in namespace N2 is derived from class A of N1, then the m1() is also accessible in class B of N2
	- Syntaxes for OOPs Concepts
		- Inheritence
			- Design a Specific class from General Purpose class
				- All Public and Protected members of the Base clas are accessible in deribed class
				- Provide Following Features
					- Reusability
					- Extensibility
			- A Class can have 'Only-One' base class
			- Single Inheritence, 
				- A Class can have 'Only-One' base class, aka Single Inheritence
				- e.g.
					- class Base {}
					- class Derive : Base {}
			- Horizontal Inheritence,
				- Multiple classes are derived from Same base class
				- e.g.
					- class Base{}
					- class Derive1: Base {}, class Derive2:Base{},...
			- Hierarchical aka Multi-Level Inheritence
				- The Derive class is also a base class for next derive class
				- e.g.
					- class Base {}
					- class Derive:Base{}
					- class Derive2:Derive{}
		- Polymorphism
			- Power of OOPs because of Inheritence
			- Same Methods with Same Signeture in Derive and Base class but with different implementation for Extensibility
				- Method Overriding (Strictly not Method Overloading, it is not Polymorphism)
					- Static Polymorphism Method Overloading (No where present) and Dynmaic Polimorphism (Actual Polymorphism)
				- Compile Time Polymorphism
		
	- Keywords
		- Access Modifiers, used to define a behavior of the member of the class
			- static, abstract, virtual, override, new, sealed 
		- The Static Member
			- The 'static' keyword
			- Member is accesible directly using class name 
			- Within the class, its is accessible only inside the static method
			- Why?
				- Use this to share common data and implementation (logic) across all methods of the class
		- The Abstract classs
			- Class that is not instantiated
			- Why?
				- Used to define blue print of implementation so that all derived classes can use it as it is or override it
			- Class can have virtual methods and abstract methods
				- The 'virtual' and 'abstract' are keywords
					- virtual and abstract methods MUST be overriden
					- IMP: Virtual methods can be as it is used by derived classs, but abstract methods MUST be overriden by the derived class with implementation, else derive class MUST be made as abstract class 
					- Virtaul Methods can hve implementation but abstract method cannot have any implmentation
		- The Sealed class
			- The 'sealed' is a keyword
			- Why?
				- Used to create a final class with final implementation which cannot be derived
		- Method Shadowing
			- Used in case when Base and derived class have same method with same signeture
			- In derive class we can make the method as 'new' to shadow it (or hide it) so that it cannot be called using derived class instance
	- C# Specifications
		- The class is by default internal 
		- All members of the class are private by default
		- The top level class can not be private, but the public class can contain a private class in it
			- public class MyClass {  private class MyInnerClass {  }   }
		
# OOPs Practically
- Class MUST be instantiated
	- e.g. ClsEmployee is the the class, then its instanbce will be 
		- ClsEmployee emp = new ClsEmployee(); 
			- The default constructor willbe invoked
			- The constructor is a method havig same name as trhe name of the class but this will not have any return type
			- If class is not instantiated the following runtime error will occur
				- "'Object reference not set to an instance of an object."
- In the class we cannot have same method with same signeture
- In case of inheritence if the base class is have paramerized constructor then the derived class MUST have the parameterized ctor and pass parameters to base class ctor 
- If the base and derived classes has same method with same signeture, then consider implementing one-of-the following solution
	- If the Derive class method wants to override the base class method method by
		- Either using base class implementation as-it-is
		- OR completly provide new implmentation
	 - Then make the base class method as 'virtual'
	- Using the 'Override' means the polymorphic behavior 
	- Use 'new'
	 

- Using the Dynamic Polymorphism
	- At runtime inform the execution engine about the type of object which contains data and let the runtime decides which actual implmentation is to be invoked for the execution  
	- This is implementing using the 'abstract' class tht contains 'virtual' and 'abstract' methods, these methods are overriden by the derived class
		- NOTE: Abstract class cannot be instantiated
	- In case of Inheritance, if an base class is passed as input parameter to a method, then while accessing this method we can pass an instnace of 'any derived class of the base class' as input parameter to a method
	- e.g.
		- class Base {}
		- class Derive1:Base {}
		- class Derive2: Base {}
		- class Client
		{
			 method1( Base b ){.... logic ....}
		}
		- Derive1 d1 = new Derive1();
		- Derive2 d2 = new Dervice2();
		- Client c = new Client()
		- c.method1(d1); -- substitute the derive for base
		- c.method1(d2); -- substitute the derive for base
	- This is Dynamic Polymorphism, because whiel executing method1(), the runtime decides which instance is used with its implementation

	- If a class is derive from Abstract base class that is having abstract methods, then the derive class MUST override all abstract methods of the base class, else derive classMUST be made as abstract class
- C# additional class features
	- Properties
		- They are 'get' and 'set' method wrappers written to initialize private data members of the class
			- 'set' to set value for private data member
			- 'get' to return value of the private data member
		- C# 3.0
			- Auto Implemented properties
				- They are the direct public properties created for the class where the Compiler write implicit backing fields (aka private members) for it
				- We cannot write an custom validation logic for get set easily 
- Usie of Interfaces
	- Interface is a type that has method definitions
	- Interface is implemented by class either Implicitly or Explicitly 
		- Implicit Implementation: The class is owner of the methods
		- Explicit Implementation: The class contains method definition but they are owned by interface
	- Rule
		- If a class implements an interface then all methods of the interface MUST be implemenetd by the class else the compiler error will be generated 
	- A class can implement Multiple interfaces
		- If more than one interfaces has same method with same signeture, then to provide different implementastion for each method in class, let the class implement these interface explicitly
	- A class can derive from "One Base class" and can implement multiple interfaces
		- This is NOT MULTIPLE INHERITENCE

- C# Some Important COncepts
	- The 'delegate'
		- Used to Execute a method with its reference
			 - Declare a delegate using 'System.Delegate' or using 'delegate' keyword at namespace level
			 - Make sure that the Signeture of the delegate MUST match with the Signeture of the method which will be invoked by the delegate
		- Used to declare an event based on condition
			- This is a special delegate that notifies that somethinmg has happened
		- Used to handle Asynchronous execution of a method as per the requirement
	- The 'event'
		- The event MUST be defined using delegate
		- The return type of the delegate MUST be void if its is used to declare an event
		- The 'event' is a keyword in C#
		- The event is raised conditionally
		- There MUST exist an class that will be notified when an event is raised  
	- The 'Generic'
		- Class
		- Interface
		- Data Member
		- Method Parameter
		- Event
		- Delegate

- C# 3.0 Programming Enhancements with .NET Frwk 3.5+
	- The Local Variable Type Inferience
		- Declare a local variable for a 'BLOCK-SCOPE' using 'var'
		- This declaration MUST be initialize
		- The Typeof 'var' will be defined based on the initial value
		- e.g.
			- var x = 10; 
				- Here x is integer
			- var str = "ABC";
				- here str in string
	- Auto-Implemented Propeties
	- Anonymous Types
		- A Class without Name
		- Used to store result from Language Integrated Query (LINQ) at runtime in encapsulated format
			- var obj = new {id=11, name="ddd", age=34};
				- The 'obj' will be an instance of the anounymous type that has properties id, name, and age
	- Extension Method
		- Adding a method externally into a class w/o modifying the class
		- Allows developer to enhance a class by adding a method w/o asking the developer to change the existing class
		- Allows developer to write enhanced methods for standard .NET Classes
		- This is the resaon new .NET Versions are available
		- Rules for Extension Methods
			- The class that contains Extension method MUST be 'static'
			- The method which is used as extension method MUST be 'static'
			- The First Parameter of this method MUST be 'this' referred reference of the 'class' for which the extension method is written 
			- E.g.
				- public sealed class MyClass { fileCreate(){} }
				- public static class FileEhnancement { static encypt(this MyClass c){....} decypt(){}, compress(){} }
					- The encypt() is an extension method for MyClass
				- Use following code to call extension Method
					- MyClass m = new MyClass();
					- m.encypt(); invoke an extension method
				
	- Lambda Expression 
		- A Simplication for Method passed as parameter to another method
		- This is a Simple Syntac for Anonymous Methods
		- They are better used when a method has a delegate as in input parameter
		- This is used espicially while using Language Integrated Queries (LINQ)

# SQL Server Programming

- E-Comm App
	- ProductName, ManufacturerName, CustomerName, CustomerAddress, City, State, ProductCategory, SubCategory, OrdreredQuantity,UnitPrice, TotalPrices, OrderDate, ShippingDate, ExpectedDelivaryDate, ActualDeliveryDate, PaymentType, ProductDescription  

- Statements
	- Data Definition Language (DDL)
		- Define Database Objects
			- Create Database|Table|View|Stored Procedure | Function | Cursor
			- ALter Database|Table|View|Stored Procedure | Function | Cursor
	- Data Manipulation Language (DML)
	- Data Control Language (DCL)

# Performing Data Access using ADO.NET
	- Set of classes those are used to perform Data Access for .NET Apps
	- Connected Approach
		- Client App is always connected to Database
		- Client Choose when to close DB Connection
	- Disconnected Approach
		- Client gest connected with database
		- Read data from Table
		- Stored data in Client app's Memory
		- Isolate itself from DB
		- Client basically update data in memory
		- Connect back to Database
		- Send Updated data
	- Namespace
		- System.Data
		- For SQL Server
			- System.Data.SqlClient, namespace provider by Microsoft
	- System.Data Object Model
		- Both Connected and Disconnected Approach
			- DbConnection
				- BAse class for Establising Connection with DB
			- DbCommand
				- Base class for Sending SQL Statements and SP (all are commmands) to perform Read/Write operations with Database
		- Only in Connected Approach
			- DbReader
				- A Cursor that stores data returned from Database using 'Select Statements'
		- Disconnected Approach
			- DataSet
				- In-Memory Database on Client side to store data from Database
				- Collection of DataTables
				- Collection of DataViews
				- Collection of DataRelations
				- DataViewCollection, a Collection of Views 
			- DataTableCollection
				- Collection of DataTables 
			- DataTable
				- Table inside the DataSet
				- DataColumnCollection
					- Schema of table
				- DataRowCollection
					- Data in the table
			- DataColumn
				- A Single Column in DataTable on Client-Side
			- DataRow
				- A Row in DataTable
			- DataViewCollection
			- DataView
				- A View created from On-or-More Tables from DataSet 
			- DataRelationCollection
				- Collection of relations (Primary-Key-Foreign-Key) across Tables on Client-Side
			- DataRelation
				- An Actual Relation Object
	- SqlServer
		- System.Data.SqlClient
			- SqlConnection
				- Derived from DbConnection for Connection Management with SQL Server Database
			- SqlCommand
				- Derived From DbCommand for Command Management
			- SqlDataReader
				- Derived from DbReader for Storeing result of Select Query from SQL Server Database
		- Disconnected Approach Object for SqlServer
			- SqlDataAdapter
				- Derived from DbAdapter
			- SqlCommandBuilder
				- Dreived From DbCommandBuilder 
	- Coding Style with Connected Approach with SQL Server
		- Connect to Db using SqlConnection class
			- Pass the Database Connection String
				- e.g.
					- Connection String fot SQL Server Windows Integrated User aka Windows User thas is havinbg access with Sql Server database 
						- Data Source=[SERVER-NAME|IP ADDRESS of Server Machine];Initial Catalog=[DATABASE-NAME];Integrated Security=SSPI;
					- if using SQL Server Authentication
						- Users created and Sored in SQL Server Database
						- E.g. User Id='sa' and Password='sa'
						- Connection  String will be
							- Data Source=[SERVER-NAME|IP ADDRESS of Server Machine];Initial Catalog=[DATABASE-NAME];User Id=[USER-NAME];Password=[PASSWORD];
					- Further References
						- https://www.connectionstrings.com/microsoft-data-sqlclient/
		- Methods of SqlConnection
			- Open(), open connection
			- Close(), close connection
		- Properties
			- Command
				- This is used to accept the SqlCommand Object that contains the SQL Statement or SP name
			- State
				- Current state of the Db Connection  
			- ConnectionString
				- Accepts Connection string to connect to Database
	- SqlCommand Object
		- Properties
			- CommandText	
				- SQL Statement or SP Name
			- CommandType
				- Where the Command has the 'CommandText' as SQL Statement or Stored Proc (Default is SQL Statement)
		- Methods
			- ExecuteReader()
				- Used with the CommandText is 'Select' Statement
				- Returns an instance fo SqlDataReader object which is a cursor
			- ExecuteNonQuery()
				- Used when CommandText is DML Statement (INSERT/UPDATE/DELETE)
				- Returns a non-zero number that represents number of records affected in Table
			- ExecuteScalar()
				- Used when the CommandText and SP Or the Select Statement that return scalar values e.g. Sum(), Avg(),Count(), Min(), Max(), etc.  
			- ExecuteXmlReader()
				- USed when the CommandText select statement is returing XML Data
	- SqlDataReader
		- Read() method to read data from Cursor
		- This is Read-Only-Forward-Only cursor
			- Starts from First Record in Cursor and advances itself to End-of-Records in Cursor
		- End()
			- Stop the cursor reading and release the pointer that is reading recorsd from the Cursor
	- SqlParameter
		- Classes that is used to pass parameterd to Stored Procedure and Parameterized Query
		- Properties we need to set while passing parameters to a SP
			- ParameterName: The NAme of the Parameter, that MUST matche with Actual Parameter Name
			- Direction: If the parameter is input (Default) or Output parameter
			- SqlDbType: The SQL Server Data Type for the parameter
			- Value: The Data to be passed to the parameter
			- Size: Set this only in case of Textual data e.g. varchar, nvarchar, etc. Default value for Size property for Textual data is 1
		- Add the SqlParameter to the Command Object
			- Cmd.Parameters.Add(SqlParameter Object)
				
- Data Access Programming Practices
	- Since the .NET App connects to SQL Server Database, its is an external resource
	- The .NET App may crash if an external resourcxe is not responding
	- To Prevent the .NET app from Crash, use an exception Handling
	- try{... CODE..TO-EXECUTE...}catch(Exception ex) {...CODE...To...HANDLE-EXCEPTION....}finally {...CODE..THAT..WILL..BE..EXECUTED..IN...CASE...OF...TRY...EXECUTION...OR...CATCH...EXECUTION}
	- catch() block, that will habdle the execution and will inform to runtime that code is successfuly Executed
	- We can also 'thow' the error message to make sure that the Application can show the error message to client
	- try
	{
	   ...
	}
	catch(Exception ex)
	{
		throw ex;
	}
	- We can have Nested try
		- try {  try { try { } } } catch(Exception ex){}

- Object Model for Performing CRUD Operations using ADp.NET Disconnected Architecture with DataSet

- Connect to Db
	- SqlConnection Conn = new SqlConnection("Connection string")
	- Define Adapter
		- SqlDataAdapter AdDept = new SqlDataAdpater("Select * from Department", Conn);
	- Declare DataSet
		- DataSet Ds = new DataSet();
	- Fill Data Into DataSet
		- AdDept.Fill(Ds, "Department"); Ds is having a DataTable of Name Department whihc contains Data Received from Database
		- Two Types of DataSet
			- Typed DataSet
				- The DataSet filled with Primary and Foreign Keys of table
			- UnTyped DataSet (Default)
				- DataSet only has Schema dn Data of the Table but not constraints (Pk and Fk)
		- We cannot find data from UnTyped DataSet using Primary key
			- Convert the UnTyped DataSet into Typed DataSet
			- AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				- Adpter is configured to read Table Constraints
			- Fill Data into DataSet
				-  AdDept.Fill(Ds, "TABLE-NAME");
	- Add a new record
		- Define a DataRow Object 
			- DataRow DrNew = Ds.Tables["Department"].NewRow(); Create a Row having same columns of Department Table
		- Set its Column Values
			- DrNew["DeptNo"]=100; DrNew["DeptName"]="dcdd"; DrNew["Location"]="Pune"; DrNew["Capacity"]=777;
		- Set the Row as a Row Collection of Department Table in Ds
			- Ds.Tables["Department"].Rows.Add(DrNew);
	- Define SqlCommandBuilder based on Adapter and ask this Builder to Update Data Back to Database
		- SqlCommandBuilder bldr = new SqlCommandBuilder(AdDept);
			- This will Connect to DB
	- Ask the Adapter to Update Data in Database
		- AdDept.Update(Ds, "Department");	
			- Read Data from Diffgram that is associated with 'Department' DataTable in DataSet
			- Check if this is New Record (Insert), Update an existing record (Update) or Delete Record (Delete)
			- The Adapter will invoke the required Command Objects and hence their CommandText (Insert,Update,Delete queries) and Update data to the Matching Table in Database 

		- InsertCommnad
			- Insert into Table values (.....);Select col1,col2....coln from Table;
				- After insert is successfuly executed, the select statement will read new data from table and send back to Adapter and adapter will update this data back to DataSet's Original section
		- UpdateCommand
			- Before Update is commited into the database the Command will check if the Original values are as it as present into tabel for that row, if these values are changed by any other client, then 'DbConcurrencyException' will be thrown

			- Update Table set Col1=New-Value, Col2-New-Value.... where
				Col1=Orig-Value, Col2-Orig-Valie......;Select col1,col2....coln from Table;
					- After update is successfuly executed, the select statement will read new data from table and send back to Adapter and adapter will update this data back to DataSet's Original section
		- DeleteCommand
			- Delete from Table where Col1=Orig-Value, Col2-Orig-Valie......;Select col1,col2....coln from Table;
				- If row is changed no delete takes place
				- After delete is successfuly executed, the select statement will read new data from table and send back to Adapter and adapter will update this data back to DataSet's Original section
	- Search Record from Typed Data Set using Primary key	
		- DataRow DrFind = Ds.Tables["TABLE-NAME"].Rows.Find(PRIMARY-KEY-VALUE);
	- Update the record
		- Search record based on P.K.
		- Chage its column values 
			- DrFind["Col1"] = New-Value;
		- Call Command Builder
			-  SqlCommandBuilder bldr = new SqlCommandBuilder(AdDept);
		- Update
			- AdDept.Update(Ds, "Table-Name");
	- Delete Record
		- Search record based on P.K.
		- Remove
			- Ds.Tables["TABLE-NAME"].Delete(DrFind);
		- Mark the Searched Row For Deletion
			- DrFind.Delete();
		- Call Command Builder
		- Update

# Web Application Programming using .NET Framework
1. ASP.NET aka WebForms (.NET 6 have deprecated the WebForm by Razor Views)
	- WebForm
		- A UI file with an extension of .aspx e.g. MyPage.aspx
			- This will have UI developed using HTML and ASP.NET WebControls
			- HTML UI runbs on Browser by default
			- WebControls are UI Elements those are only executed on WebServer 
		- Each UI file has Logic with it aka the 'Code-Behind' file
			- e.g. is UI file is MyPage.apsx, the Code-Behind file will be MyPage.aspx.cs
			- This file contains class that is derived from 'Page' class
			- This class defines events for various WebControls e.g. click for button, textchange for TextBox, change for DropDown  
			- The Page class also has 'LifeCycle' that manages an execution of Page on WebServer
	- ASP.NET Programming
		- WebForm Application Folder Structure
			- .aspx files
				- WebForm UI Pages
			- .master files
				- Master Page file that has common UI layout for all .aspx pages
			- Global.asax file
				- The Entry-Ppint to Web App when the request is accepted by IIS and the Web Application (Web Site) is located
				- This file contains code for
					- Process Request
					- Session State Management
					- Application State Management
					- Application Error
			- Web.config file
				- Heart of Web App 
				- Application Level Configuration as follows
					- Database Connection string
					- Authentication
					- Custom Configurations
					- External Dependencies used by the Current Web App
			- App_Data Folder
				- A Data folder that contains data files used by the application e.g. XML, JSON, CSV files. The .mdf (SQL Server Database) file
			- App_Start Folder
				- Contains class for Routing Information
				- Class for creating bundle for .js,.css files so that they can be hosted on IIS Web Server and responded to browser with HTTP Response
			- Content Folder
				- The Bootstrp CSS Framework files
				- Used for Rich UI
			- fonts
				- Contains CSS Fonts
			- Scripts Folder
				- Contains the jquery, JavaScript Files
		- Master Files
			- Common Layout Files
```` html
				- <%@ Master Language="C#" AutoEventWireup="true" CodeBehind="Site.master.cs" Inherits="WebForm_App.SiteMaster" %>

````
				- @Master is 'Directive', this represents the current file is Master Page
					- AutoEventWireup: Events on UI will be habdled explicitly
					- CodeBehind: The Code behind file that contains C# Code
					- Inherits: Links the Site.master file to site.master.cs file, the Code-Behind file, this file contains the class name 'SiteMaster'
						- When the Site.master file is loaded actualy an instance of 'SiteMaster' class will be executed
```` html
  <asp:ContentPlaceHolder ID="MainContent" runat="server">
            </asp:ContentPlaceHolder>
````

		- ContentPlceHolder is Control that contains and renders .aspx as child page
			- MainContent is an id which will be used by .aspx page so that it can act as a child of Master Page
			- runat=server, means the page is executed on server

```` html
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm_App._Default" %>

````
		- The 'Page' is adirective that represents the ASP.NET Web Form which will be executed on server
			- MasterPageFile: When this page is requested the Master Page (site.master) will be loaded on server, first the master page class will be executed then the aspc Page will be executed
			- Inherits will link the UI file with its code-behind file
			- The class i.e. _Default will be executed on Server in the '_Default.DLL' (The Page Assembly) when the Default.aspx is requested  
```` html
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
````
		- The 'Content' is a control that COntains UI of the Page
			- ContentPlaceHolederID: this is the 'id' of the  'ContentPlceHolder' of the Master page under which the current aspx page UI is loaded and rendered 
		- Understand WebForm and WebControls
			- WebForm
				- A 'Page' object that has lifecycle events(?) which managed the execution on server (?) for the UI when it is posted back to server fronm Browser
				- A Container Object that contains UI Objects (HTML and WebControls) and the evnets for these UI objects 
			- WebControl
				- The ASP.NET Server Cobtrols those are executed ion Server
				- All these are Derived from immediate base class known as  'WebControl' which is deribed from 'Control' Base class
				- The server controls is used as follows on the Page (WebForm)
```` html
			<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
````
			- The 'asp:' means this is WebContorl
			- The 'ID', the server-side identiication of the control
			- The 'runat="server"' means this will be executed on the server when the Page is Posted BAck (aka submitted) to the server 
			- The 'WebControl' class has various mathods but following asre important
				- Render(HtmlTextWriter)
					- Generate HTML stream using the HtmlTextWriter class for the WebControl to its matching HTML element
					- e.g.
						- asp:TextBox the rendering will be input type="text"
				- RenderContent(HtmlTextWriter)
					- Render the WebControl with its children (Contents) into HTML form using HtmlTextWriter
					- This also takes care of the Data of the control shown on Browser using HTML
				- RenderBeginTag(HtmlTextWriter)
					- Generate HTML Start Tag based on Render() HTML Stream
				- RenderEndTag(HtmlTextWriter)
					- Gennerate HTMl End Tage for Start Tag
			- DataBound Web Controls
				- Used to Display Collection aka IEnumerable as Source
				- Properties
					- DataSource: USed to Accept the Collection from which data will be shown
					- DataTextField: A Property that contains the Display Member which is the Text Value e.g. In a collection of Departments, the DeptName will be Display Member 
					- DataValueFiled: The value of the selected Member
					- DataMember: The onse which is selected
				- DropDownList
					 DataSource
				- GridView
					 DataSource
				- ListView
					 DataSource
				- FormView
					 DataSource
			- The 'EnableViewState', the property of WebControl that is responsible to maintain the data associated with the Control during the Postback of the Same Page 
				- EnableViewState="True", by default
				- Setting EnableViewState to false, means that each time the control and its values will be initialized and the SaveViewState() method will fail to maintain the previos data of the control and hence it will also fail to load the previous data of the control 
			- If EnableViewState=true is causing the repeted data in DataBound Controls because of 'page-load' event, then to prevent the code of the page_load from exection for each postback (submit), use the 'IsPostBack' flag of the Page class
				- Ths IsPOstBack is false for the first request of the page and for the next consecutive requests for the same page the value of IsPostBack will be true
			- Frequently used Controls for WebForm
					- Evnets of Each Web Control will be alwys by default executed on server, to execute these events on server, the Page "MUST BE POSTED BACK TO SERVER" 
				- asp:TextBox
					- TextChanged
						- Default Event
					- To Post Page Back to Server for TextChanged Event, set the 'AutoPostBack' property of the TextBox to true 
				- asp:Button
					- Click
						- Event
						- asp:Button will be rendered as input type="submit" in browser and this will post page back tot server
				- asp:Lable
				- asp:DropDownList
					- SelectedIndexChanged
						- Default Event
					- To Post Page Back to Server for TextChanged Event, set the 'AutoPostBack' property of the TextBox to true	
				- asp:RadioButton
					- To Post Page Back to Server for TextChanged Event, set the 'AutoPostBack' property of the TextBox to true 			
				- asp:CheckBox
					- To Post Page Back to Server for TextChanged Event, set the 'AutoPostBack' property of the TextBox to true 			
				- asp:RadioButtonList
					- To Post Page Back to Server for TextChanged Event, set the 'AutoPostBack' property of the TextBox to true 			
				- asp:CheckBoxList
					- To Post Page Back to Server for TextChanged Event, set the 'AutoPostBack' property of the TextBox to true 			
				- Note: DataBOund Controls
					- These are WebServer Controls those are used to show data from IEnumerables aka Collections
					- The data from Collection MUST be bound to all DataBound Controls using 'DataBind()' method
				- asp:GridView
					- DataSource Porperty to sho data from Collection
					- To Maintain the View-State of the data during PostBacks of Sample page use
							- DataBind() method
				- asp:ListView
		- State Management
			- ASP.NET Web Core Objects
				- Request
				- Response
				- Server
				- Session
			- Session: Every New Fresh Request to the application. Within a session the client can send requests to the Server Multiple Times.
			- State Management, It is a Process where the data is maintained in-side the server's process and then as of the need this data will be made available for:
				- Across all consecutive requests for the same page in a session
					- ViewState
						- The 'Page.ViewState' property
						- Maintain the state using the Hidden Field
						- For WebControls, this is Managed using 'EnableViewState'
					- Advantages
						- Maintain the state of the data across all consecutive requests for the same page
						- We need not to use un-necessary static
					- Boundries
						- UnNecessary ViewState will increase the memory utilization on the server
						- This will reduce the Performance
						- Since it is for one-single page, when we move from this page to other page the data stored in ViewState for that page will be deleted/Remnoved 
				- Across Two-Pages in a Same Session
					- QueryString
						- Portion of the URL After the '?' provided in the form of 'Name=Value' pair 
						- e.g.
							- http://myserver.com/pages?Name=ASP.NET
							- The 'Name=ASP.NET' is QueryString
							- The 'Name' is Key and 'ASP.NET' is value
					- Move from One-Page-To-Other
						- Response.Redirect("URL-OF-THE-TARGET-PAGE?Name=Value");
					- Read the Data from QueryString on the Target Page
						- Request.QueryString["Name"];
					- Data is available for reading in the URL in AddressBar and can be changed by anybody
					- The length of characters in the address bar mujst not be more than 1024 
					- URL Invalid characters
						- /, #, >,<
					
				- On the Browser for the Same Sesion i.e. across multiple pages in a same session
					- Cookies
						- Ther are the files physically  created on the Client's machine and data will stored in it
							- HttpCookie infoCookie  =new HttpCookie("Name-Of-The-Cookie");
							- e.g.
								- HttpCookie infoCookie  =new HttpCookie("Info");
								- Info["Key1"] = Value1;
								- Info["Key2"] = Va;ue2;
							- Request.Cookeis.Add(infoCookie);
							- To Retrieve
								- var cookie = Request.Cookies["Info"], 
									- Read data from Cookie
								- var val1 = cookie["Key1"].Value;
								- var val2 = cookie["Key1"].Value;
				- Across multiple Sessions at Application Level
					- Session
						- For every New Session a Copy of Session Object(s) will be created
						- e.g.
							- For 10 Session Object and 1000 Active Session, the Web Server have to store 10000 Session Objects
							- Please Note, Try to reuse the session Object
					- Application	
			- Client-Side State Management
				- ViewState, QueryString, Cookies
			- Server-Side State Management
				- Session and Application
		- Validation Controls
			- Server-Side Control those are attached with WebControls to Validate its Values
				- RerquiredValidator
				- RegularExpressionValidator
				- CompareValidator
				- EmailValidator
				- RangeValidator
				- CustomValidator
		- Caching
		- Data Access
		- Security
2. ASP.NET Mode-View-Controller (MVC)