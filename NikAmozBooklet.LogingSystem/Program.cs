using Microsoft.EntityFrameworkCore;
using Serilog;
try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Host.UseSerilog((ctx, lc) =>
    {
        lc.WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}")
        .Enrich.FromLogContext()
        .ReadFrom.Configuration(ctx.Configuration);
    });

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer(); 
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();
    app.MapControllerRoute("Default", "{Controller=Product}/{Action=GetProduct}/{Id?}");

    app.Run();


}
catch (Exception ex)
{
    Log.Fatal(ex, "Unhandeld Ex");
}
finally
{
    Log.Information("Shut Down Complated");
    Log.CloseAndFlush();
}