var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/Cookie", (HttpContext context) =>
{
    context.Response.Cookies.Append("firstcookie", "Hello", new CookieOptions
    {        
    });
});

app.MapGet("/{segment01}.cookie", (HttpContext context) =>
{
    var cookievalue = context.Request.Cookies[context.Request.RouteValues["segment01"].ToString()] ?? "NULL";
    context.Response.WriteAsync(cookievalue);
});

app.MapGet("/ClearCookie", (HttpContext context) =>
{
    context.Response.Cookies.Delete("firstcookie");    
});
app.MapGet("/", () => "Hello World!");
app.Run();
