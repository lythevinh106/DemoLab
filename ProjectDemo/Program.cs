using Microsoft.EntityFrameworkCore;
using ProjectDemo.Configurations;
using ProjectDemo.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ProjectDemoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.ConfigureRightStoreServices();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
