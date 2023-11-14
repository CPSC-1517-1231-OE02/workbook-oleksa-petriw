using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using WestWindWebApp.Data;

// Required namespaces
using WestWindSystem;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

//builder.Services.WWBackEndDependencies(options =>
    //options.UseSqlServer("Server=.\\SQLEXPRESS;Database=WestWind;TrustServerCertificate=True;Trusted_Connection=true")
//);

//using the connection string from the json file instead of the above
var connectionString = builder.Configuration.GetConnectionString("WWDB");

//substituting it in to the original wwbackenddependencies code from above
builder.Services.WWBackEndDependencies(options =>
    options.UseSqlServer(connectionString)
);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();