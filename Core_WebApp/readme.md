# ASP.NET Core 6 

1. Cross-Platform Web App Dev. Technology
2. Eco_system for
	- Razor Views (Replacement of WebForms aka .aspx)
		- No Web Controls, instead use HTML Element System
	- MVC
		- Quite Similar with ASP.NET MVC
		- Huge Modification internally
		- Razor Views
		- No Web Controls
		- HTML based UI
			- The HTML Helpers are Removed
	- API
		- Huge Modification internally
		- Purely based on HTTP Action Methods (GET / POST / PUT / DELETE)
3. Breaking Changes
	- Common HTTP Pipeline for Razor Views, MVC, adn API
	- A Same Object Model for all Requests (Razor Views, MVC, and API)
	- Inbuilt Support for Dependency Injection
		- All Depednencies are directly Added into the Request Pipeline using 'IServiceCollection'
		- The Lifecycle of all dependencies is managed internally
	- No HttpHandler and HttpModule
		- BEcause they are written for IIS on Windows
		- Hence No Global.asax and Web.Config
	- Instead
		- WebApplicationBuilder
			- A Contract between the ASP.NET Core app and the Hosting Environment (e.g. IIS, Server on Linux, Docker, Self-Hostt, etc.)
		- Middlewares
			- Replacement for HttpHandler and HttpModule
	- Security Changes
		- No Security
		- Individual User Accounts
			- SQL Server with Tables for Security
		- Microsoft Identity Platform
			- Used in case of Cloud Deployment
			- An Integration with Azire Active Directory (AzureAD)
4. Microsoft.NetCore.App
	- .NET Core Assembly
	- Has all standard classes for Application Development
5. Microsoft.AspNetCore.App
	- ASP.NET Core Runtime
6. MOst suited for Moden Microsservices Apps

# Add Ons to .NET 3.1 +
	- Blazor
		- Bowser Based Interative UI Technology
		- This will load the .NET Runtime on Browser
	- gRPC
		- Data Comminication Terchnology used for Builing Large-Scale Destrubuted App 


# Project
	- Program.cs
		- Start Hosting the App
		- Register All Dependencies in Dependency Container using IServiceCollection
		- Web Core Objects registered in The dependency Conmainer
			- Controllers(), API Controllers
			- ControllersWithView(), MVC and API Controllers
			- Session
			- Cache
			- Secuiuty
			- Database Connection
		- Registeing all Middlewares using IApplicationBuilder Contrac5t Inteface
			- Security
			- Exception
			- Cross-Orgin-Resource-Sharing(CORS)
			- Session()
			- Cache()
			- Custom Registratoin of Moiddlewares
