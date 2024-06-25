using Microsoft.EntityFrameworkCore;
using RecipeManagement_System.Context;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<RMSDbContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("RMSconnectionstring")));


builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
 
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
