using Beginning.MiddleWare;
using Beginning.MiddleWareAndRouting;
using Beginningx;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<RouteOptions>(opts =>
{
    opts.ConstraintMap.Add("nationalCode", typeof(CustomConsterint));
});


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseMiddleware<FirstMiddleWare>();

app.UseRouting();

//اگر این بین یک میدل ور بنویسیم میتونیم به اطلاعات اند پوینت انتخابی دسترسی پیدا کنیم 
app.UseMiddleware<checkendpoint>();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/salam", context => context.Response.WriteAsync("Hello"));
    endpoints.MapGet("/class", new FirstMiddleWare().InvokeAsync);
});

//به جای خط 10 تا 15 
app.MapGet("/salam", context => context.Response.WriteAsync("Hello"));//Terminal middleware نیست.

// تعریف متغییر در URL
app.MapGet("/{segment01}/{segment02}/{segment03}", async context =>
{
    var routes = context.Request.RouteValues;
    foreach (var route in routes)
    {
        context.Response.WriteAsync($"{route.Key} : {route.Value} {Environment.NewLine}");
    }

});


//اعمال محدودیت و بزرگ کردن محدوده پذیرش 
app.MapGet("/{segment01}/{segment02=yasin}/{segment03?}/{*catchall}", async context =>
{
    var routes = context.Request.RouteValues;
    foreach (var route in routes)
    {
        context.Response.WriteAsync($"{route.Key} : {route.Value} {Environment.NewLine}");
    }

});

//اعمال محدودیت و گذاشتن شرط 
app.MapGet("/{segment01:lengh(10)}/{segment02:bool}/{segment03:minlengh(2):maxlengh(10)}", async context =>
{
    var routes = context.Request.RouteValues;
    foreach (var route in routes)
    {
        context.Response.WriteAsync($"{route.Key} : {route.Value} {Environment.NewLine}");
    }

});

app.MapGet("/{segment01:nationalCode}", async context =>
{
    var routes = context.Request.RouteValues;
    foreach (var route in routes)
    {
        context.Response.WriteAsync($"{route.Key} : {route.Value} {Environment.NewLine}");
    }

});

//اگر پردازش آدرس رو هیچ کس بر عهده نگرفت سراغ فال بک میره 
app.MapFallback(async context => context.Response.WriteAsync("start FallBack"));


//زمانی که چند آدرس با شرایط یکسان داریم میتونیم اولویت بدیم 
app.MapGet("/{segment01:nationalCode}", async context =>
{
    var routes = context.Request.RouteValues;
    foreach (var route in routes)
    {
        context.Response.WriteAsync($"{route.Key} : {route.Value} {Environment.NewLine}");
    }

}).Add(c => ((RouteEndpointBuilder)c).Order = 1);

app.Run();
