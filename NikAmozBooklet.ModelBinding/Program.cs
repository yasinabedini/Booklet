using Microsoft.EntityFrameworkCore;
using NikAmozBooklet.ModelBinding.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


builder.Services.AddDbContext<MbDbContext>(db => db.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.MapDefaultControllerRoute();
app.MapRazorPages().Add(c => ((RouteEndpointBuilder)c).Order = 2);
app.Run();
