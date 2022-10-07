using dotnetcoreTemplate;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Conecting to database
// Files:
//      appsettings.json && appsettings.Development.json
//      ./Models/DatabaseContext.cs
// Commands:
//      dotnet build --runtime linux-x64
//      dotnet ef migrations add "example"
//      dotnet ef update database --runtime linux-x64
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AzureConnection")));



// Default stuff from template
// ========================================
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.Run();
