using Mentor_App.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MentorAppDbContext>(options =>
    //options.UseSqlServer(config["ConnectionStrings:DefaultConnection"])
    options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
    //options.UseSqlServer(config.GetSection("ConnectionStrings:DefaultConnection").Value)
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
