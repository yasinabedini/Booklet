using DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


//تزریق وابستگی قرارداد و کلاس
builder.Services.AddSingleton<IDependencySinglton, DependencySinglton>();

//تزریق کلاس بدون قرارداد
builder.Services.AddSingleton<ConcearteSinglton>();

var app = builder.Build();

app.MapGet("/conc", (HttpContext context, ConcearteSinglton singlton) =>
{
    context.Response.WriteAsync(singlton.GetGuid());
});

app.MapGet("/dis", (HttpContext context, IDependencySinglton singleton) =>
{
    context.Response.WriteAsync(singleton.GetGuid());
});
app.Run();
