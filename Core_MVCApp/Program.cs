using Core_MVCApp.Models;
using Core_MVCApp.DataAccess;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add the DepartmentDaraAccess and EmployeeDataAccess into the DI Container 

builder.Services.AddScoped<IDataAccess<Department,int>, DepartmentDataAccess>();
builder.Services.AddScoped<IDataAccess<Employee,int>, EmployeeDataAccess>();

// The Servivice that will manage request Processing for MVC Controllers and respond Views as well as the API Controllers. i.e. AddControllersWithViews()
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages(); // For Razor Views (replacement for WebForms (WebForms are deprecated with ASP.NET Core 6))
builder.Services.AddControllers(); // For API Controllers

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// Map the incomming Http request to Https request in Production
app.UseHttpsRedirection();
// Used to read static file (if any) added in the Project
// USed in case of File Upload and Download
app.UseStaticFiles();
// This middleware will be used to Create a Route Table
// This is common for API as well as the MVC Controllers
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
