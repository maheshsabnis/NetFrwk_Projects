﻿# ASP.NET WEB API
- The REST API Technology for .NET Framework
- The ApiController
	- Base class for WEB API
	- Contains Http-Action Methods
		- HttpGet, HttpPost, HttpPut, and HttpDelete
- Steps for ApiController Execution 
	- Server Accept Request
		- e.g.
			- http://www.myserver.com/api/MyController
	- The Route Table will Evaluate the URL and will  Read the 'Path-Expressoin'
		- '/api/MyController'
	- Thsi will be passed to RouteHandler
		- Check the 'Matching ApiController'  to the MyController and the information will be passed to the HttpHandler
	- HttpHandler will look for 'MyController', if found then the Instance of MyController class 'inside the ControllerContext' will be created
		- Verify the Security (If applied)
			- If the Security Failed the HTTP Response with UnAuthorized (401) will be send
		- Load and Instantiate Action Filters (If Applied)
		- The Dependency will be injected (If the DI is used)
		- The 'Controller' instance will be generated 
	- Action Execution
		- The Http request Type (Get/Post/Put/Delete)
		- Based on the HttpRequest Type the the Action Method will be mapped
			- HttpGet -- Get()
			- HttpGet:id -- Get(id)	
			- HttpPost -- Post()
			- HttpPut -- Put()
			- HttpDelete -- Delete()
		- The ActionExecutionContetx
			- Check for Security Filter (If Applied)
			- Load and Initialize the Action Filter (If Applied)
			The Action Method will be executed
				- Validate the Model (Post and Put Requests Only)
					- ModelState
				- Model Updated
				- Data Response as HttpResponse Message 
- Install Unity.WebApi package for DI				

- IHttpActionResult
	- The Contract Intarface that represents the HTTP Reponse send after the Action Method from the WebAPI is executed Successfully
		- Ok()
- To Access The REST API using .NEt Framework Client App using
	- System.Net.Http
		- Install Package
		- Usie HttpClient class
	- System.Web.WebClient

- When a Pure JavaScript Client App (jQuery, Angular, React, Vue, etc.) are tryinh to Access the REST APIs, the REST API will generate the Cross-Origin-Resource-Sharing (CORS) error and this will prevent the response to the JS Client. To avoid this, the WEB API (REST APIs) MUST be configure to enable CORS Policy 
	- Install the Microsoft.AspNet.WebApi.Cors package


- Deployment of the Application
	- Local Deployment on IIS aka On-Premises Deployment
		- On the Server Machine i.e. Windows Server 2012+, The IIS MUST be configured and Possibly instalkl SQL Server
		- On IIS Create an Application-Pool targeteed to .NET Framework 4.0
		- COnfigure the IISAPPOOL as a User in SQL Server Database
		- Create a Web Site under this Application-Pool
		- Public the ASP.NET Web Form, ASP.NET MVC , and WEB API app on this this Web-Site
	- Cloud Deployment Azure
		- Deploye the Database on Azure SQL
		- Change the Connection String in WebForms, MVC, and WEb API Project and test it
		- Publish the WebForms, MVC, and WEb API app on Cloud
