// The Contract with the Hosting Environment
var builder = WebApplication.CreateBuilder(args);
// The 'builder' object, the object whihc is a Container for following
// 1. Dependency Services
    // builder.Services
// 2. Middlewares
    // builder.Build()


// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
