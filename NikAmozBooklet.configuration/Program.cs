using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);
//Add Provider
builder.Configuration.SetBasePath(builder.Environment.ContentRootPath).AddJsonFile($"appsettings.json",true);
//builder.Configuration.AddKeyPerFile("Path", false, true);


var app = builder.Build();

//............................................
var config = builder.Configuration;

var iConfig = builder.Configuration.GetSection("CustomerName");

app.MapGet("/config", (HttpContext context, IConfiguration IConfiguration) =>
{
    context.Response.StatusCode = 200;
    context.Response.ContentType = "text/Html";
    context.Response.WriteAsync($"<h1>{iConfig["FirstName"]}<h1/>");
    context.Response.WriteAsync($"<h3>{config["CustomerName:lastName"]}");
});


app.Run();
