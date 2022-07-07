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