using Microsoft.AspNetCore.Mvc;
using NikAmozBooklet.ModelValidation.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MvDbContext>();

builder.Services.Configure<MvcOptions>(option =>
{
    option.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(c=>"");
});

var app = builder.Build();

app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();
