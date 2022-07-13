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
