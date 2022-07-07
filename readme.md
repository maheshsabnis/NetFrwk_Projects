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