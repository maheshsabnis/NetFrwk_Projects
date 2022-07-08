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
		 