using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NikAmozBooklet.AAA.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AAADbContext>(cs => cs.UseSqlServer("server=YasiAbdn\\ABDN;initial catalog=aaadb;integrated security=true;TrustServerCertificate=True"));
builder.Services.AddIdentity<CustomUserIdentity, IdentityRole>(c =>
{    

}).AddEntityFrameworkStores<AAADbContext>();


var app = builder.Build();
app.UseStaticFiles();
app.UseDeveloperExceptionPage();
app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();
