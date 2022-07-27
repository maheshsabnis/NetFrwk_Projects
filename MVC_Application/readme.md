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
						- Index View
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

