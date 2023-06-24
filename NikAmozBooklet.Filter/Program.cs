using NikAmozBooklet.Filter.Filters;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddMvcOptions(option =>
{
    option.Filters.Add<MyHttpsFilterAttribute>();
});

builder.Services.AddScoped<GuidPrinterAttribute>();

var app = builder.Build();

app.MapDefaultControllerRoute();
app.Run();
