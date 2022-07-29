# ASP.NET MVC

1. Models
	- A Layer where it contains Data Access, Business Logic, and Entities
2. View
	- A User Interface, this ig Generated (Scaffolded) based on Entity Class passed to it
3. Controller
	- This is a class that contains 'Action Methods'(?)
		- Actoin Methods are those methods which will be executed based on HTTP Request received from View
			- Http Get
			- Http Post
	- Action Methods are responsible to Update Model based on data rfeceived from View, and will also received updated data from Model and pass it back to View
	- Controller's Accepts requests from the End-User (using Views) and then will execute action method
	- Controllers has following
		- Security, to decide for which user/role which action method can be execute
		- Filters, used to add additional logic to an action method when the action metrhod is executed 
			- e.g.
				- Log Each request
				- Handle Exception
- Folder Structure
	- App_Data, contains data files used by the MVC Application e.g. SQL Server .mdf file, XML files, JSON files, etc.
	- App_Start
		- Contains Routing
		- Filter Registration
		- CSS and JS frile Bundles
	- Content, for fonts from CSS
	- Scripts
		- JavaScript (aka jQuery Files) and also developer defined js files

	- Models
		- Contains Entities, Business Logic, and Data Access
		- We can write all these in the seperate .dll files
	- Controllers
		- Contains all Controllers
		- Controller class has the base class as 'Controller'
		- Each Action Method in the controll by default returns 'ActionResult'
		- The ActionResult, represents the response send to the HTTP Request as one of the follows
			- ViewResult, the View as HTML in HTTP Response
			- JavaScriptresult, returns a JavaScript  in HTTP Response
			- JsonResult, return a JSON data in HTTP Response
			- EmptyResult, the HTTP Response contains nothing
			- FileContentResult, Open the 'textfile' on server, read contents of the file and return it in in HTTP Response
			- FileResult, Download the File amnd open in browser e.g. Image, PDF, etc.
			- FilePathResult, Downoad the file
	- Views
		- Contains all Views
		- Folders Mapped with the 'Controller-Name'
		- E.g.
			- The Controller Class Name is 'DepartmentController' (Controller Name is Mandatory)
			- The New Sub-Folder will be created in 'Views' folder of name 'Department'. This folder will contains all Views those are handled by the DepartmetnController
			- Based on 'Action_Method_Name' from Controller class, views (Razor Views) will be added (aka Generated aka Scaffolded) having same name as 'Action_Method_Name' of the controller by default
				- e.g. If DepartmentController has an action method name as 'Index()', then the 'Department' Sub-Folder of 'Views' folder will have a Razor View of name 'Index.cshtml'
		- View, while scaffolding are passed with the 'Model aka Entity class' (Entity class is a class with public properties)	
			- The View will be generated with 'HTML Helper Controls'
				- HTML Helper Controls: These are newly defined controls by Microsoft for MVC Views
				- They are lightweight HTMl Elements
			- View Types
				- Strongly-Types Views
					- Views those are passed with Entity class
					- Page View
						- Executes as a complete Page
					- Partial View
						- Works like UserControl
					- View Scaffolding Policies
						- List View (Index)
							- Accepts the List of Entity Class (aka IEnumerable of Entity class) to show data in HTML Table
						- Create View
							- Accepts an Empty Entity class instance to create a new Record
							- Generates TextBoxes to accept data
						- Edit View
							- Accepts an  Entity class instance with data to update the Record
							- Generates textBoxes that show an exisitng data which can be modified 
						- Delete View
							- Accepts an  Entity class instance with data to delete the record
							- Read-Only UI Element e.g. div tahs of HTML
						- Details View
							- Accepts an  Entity class instance with data to show the record
					- All HTML Helper Controls used on Razor View are Bind witrh Entity (aka Model) propeties using Lambda Expression to show the data and accept the data
						- These Lambda Expression updates Model property values Directly on View
							- No AutoPostBack, and EnableViewState
				- The Base Class for View is 'WebViewPage<TModel>'
					- TModel, is the type of Model class pass to the view while scaffolding
					- The 'Model' property of the class of the type TModel
						- This represents an 'instance of the Entity class passed to View' while scaffolding
						- e.g. If View is Index and Model class passed to it as IEnumerable of Department
							- then the datatype of Model property will be IEnumerable of Department
					- The 'ViewData' of the type 'ViewDataDictionary'
						- Used in case when the Actio Method wants to pass additional data to viiew than the Entity Class properties
					- The 'Html' property of the type 'HtmlHelper'm, used to access HTML Helper UI elements on View
						- e.g.
							- Html.EditorFor, Like TextBox
							- Html.Select, like DropDownList
				- Views Without Models
					- Empty View Without Model 
	- Web.Config
		- Application Level Confoiguration e.g. Connection String
		- Sessions Settings
	- Global.asax
		- ProcessRequest
		- Creating Route Table
		- Managing Dependency Registrations used for Dependency Injection

# MVC Programming
1. Add Model Classes in Models folder or else, you can use the .dll reference
	- Build the project, so that the Models are ready to use for Generating (Scaffolding Views) from controller
2. Right-CLick on the Controllers folder and add a new 'MVC Controller' 
```` csharp
public abstract class Controller : ControllerBase, IActionFilter, IAuthenticationFilter, IAuthorizationFilter, IDisposable, IExceptionFilter, IResultFilter, IAsyncController, IController, IAsyncManagerContainer
````

- Controller: Contains methods for Request Processing, methods for sending responses,
	- Properties for
		- Accepting Httprequest and Generating HttpResponse
		- ModelState Property for Validating values posted for the Model class using HTTPrequest  
		- RouteData of type 'RouteData', this represents the Current URL in AddressBar and heps to read data from the URL
	- Interfaces implemented by the Controller
		- IActionFilter: Interface which is used to apply Action Filter (?) on Controller or its action Methods
			- The 'Action Filter' is a class that contains additional logic which we want to execute when the Controller and its action methods are executed, e.g. Logging, Security, Exceptions, etc.
		- IAuthenticationFilter, IAuthorizationFilter: Provide methods to manage the security for the Controller
		- IExceptionFilter: Provide methosd for Handling Controller Level Exceptions for all action Methods
		- IResultFilter: What result will be generated, e.g. view, redirect to other controller, File, FileStream, etc. 
	- It is recommended that the MVC MUST use the Dependency Injection  for the DataAccess and other external dependencies
		- Right-CLick on 'References' and select 'Manage NuGet Packages' and Select Unity.Mvc and Install it
		- This will add the UnitConfig.cs file in the App_Start folder, this file contains class for Registering all dependencies. Modify this call for adding your project dependencies
		- To Generate the view do the following
			- Right-CLick inside the action and select option 'Add View', then from the Add View Windows Select View Template (List/Create/Edit/Delete/Details/Empty) and the select the Model class 
	- IMP*********** Controller Fact
		- By default each action method of the Controller is HTTP GET. The View can be generated from HttpGet Action Method only, The default attribute applied on the Http Get methods is [HttpGet] (Not Mandatory for MVC Controllers for Get methods because it is default), but for Post methods the [HttpPost] attribute MUST be applied on action Methods
		- The HttpPost from View will execute the action method from the COntroller that matched with the name of the View and this method should be applied with [HttpPost] attribute

# Validating Model Properties using Validation Rules
	- System.ComponentModel.DataAnnotations.dll assembly
		- The Abstract class named 'ValidationAttribute'
			- ErrorMessage property
			- bool IsValid(object value)
				- If value is valid against the rule then return true else return false
		- RequiredAttribute : ValidationAttribute
		- StringLengthAttribute : ValidationAttribute
		- RegExAttribute: ValidationAttribute
		- ComparerAttribute: ValidationAttribute
	- If the Entities are in different .dll file, then Install the  System.ComponentModel.DataAnnotations package for validation rules
	- When the Page is rendered to the browser all validations will ber presented as 'UnObstructiveValidators' aka HTML 5 Clean Validators 
	- If you want to write a custom validator trhen make sure that the class is derived from 'VFalidationAttribute', write a logic by overriding 'IsValid()' method. Make sure  that, the class name ends with the word 'Attribute'
	- Asynchronous Validations aka Remote Validation
		- Used to Validate values entered on UI by executing an Asynchronous logic on the server 
		- RemoteAttribute the class that is used for validation
			- Apply this attribute on the property which should be validated asynchronously
			- This class is provided by 'System.web.Mvc.dll' assembly
			- E.g.	
```` csharp
	[Remote("ActionName", "ControllerName", ErrorMessage="")]
	public int EmpNo {get;set;}
````

			- ControllerName: The MVC Controller that contains the the Action Method of name 'ActionName' which contains logic for validation	- The Action Method 'ActionName' MUST accept the Property Name that is to be validated asynchrponpusly and this MUST return 'JsonResult'
				  - The view will make a JAVASCRIPT Async call to this action method fopr validation  
- To send addditional data then the Model class properties to View from Action Method use ViewData or ViewBag, if yoiu want to pass the Collection to View using ViewBag or ViewData use 'SelectList' class from System.Web.Mvc  	
	- IMP NOTE: While using ViewData or ViewBag
		- If the Action Method is passing ViewBag or ViewData to view to show the data on it, then all action methods returning the same view MUST pass the ViewBag or ViewData to View otherwise the View will crash 
				
# Action Filters
- They are the logical blocks those are executed when the MVC Request Processing is un der execution
- They can be applied for a Specific Action Method, For a controller (and hence fo all action methoods of the controller) and also at the Global level (and hence for all controllers in Applciation)
	- Object Model
		- IActionFilter intercace
			- An Interface implemented by Action Filters
		- ActionFilterAttribute class
			- The abstract base class that is implemenetd by all Action Filter Classes
		- Standard Filters
			- HandleErrorAttribute
			- AuthorizeAttribute
			- ExceptionFilterAttribute
			- ResultFilterAttribute
		- HandleErrorInfo Class
			- A Model Class that contains error Messages
	- A Mechanism of Handling Exceptions in ASP.NET MVC Controllers
		- Use Try..Ctach block in each action method
			- Code Length will be more
		- Overried 'OnException()' method for each controller and this method will be used to handle exception for any action method for that controller
	- The HandleErrorAttribute can be directly applied on the Controller with ExceptionType and Veiw as follows
```` csharp
[HandleError(ExceptionType = typeof(Exception), View = "Error")]
````
		- To Show the Error Page, Modify the Web.Config file to Handle Custom Error as follows
```` html
	<customErrors mode="On"></customErrors>
````

	- Registeirng the ExceptionFilter at the Global Level
		- Modify the FilterConfig class from App_Start for registering filters
			
			
- Creating Custom Action Filters
	- Why Needed: We want the additional Logic to be executed while the request is being Processed
		- e.g. Log Each Incomming Request in Database	
	- How: The class will be derived from ActionFilterAttibute class and will override its methods
		- OnActionExecuting, OnActionExecuted, OnresultExecuting, and OnresultExecuted 
