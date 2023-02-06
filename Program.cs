
using FrontToBack2.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var conString = builder.Configuration["ConnectionStrings:Default"];
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(conString));

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=index}/{id?}"
    );

app.Run();
