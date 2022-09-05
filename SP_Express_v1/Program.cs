// using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SP_Express_v1.DB.Concrete;
using SP_Express_v1.DB.Contract;
using SP_Express_v1.Models;

// using Microsoft.AspNetCore.Authentication.Cookies;
// using WebApplication1.Models;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));
// builder.Services.AddDbContext<ApplicationContext>(options =>
//    options.UseSqlServer(connectionString));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => {
        options.Password.RequiredLength = 8;
        options.Password.RequireLowercase = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireDigit = true;
    })
    .AddRoles<IdentityRole>()
    .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<IdentityUser, IdentityRole>>()
    .AddEntityFrameworkStores<ApplicationContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
    options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
});


builder.Services.AddTransient<IDbSelect, RepoDbSelect>(provider => new RepoDbSelect(connectionString));
builder.Services.AddTransient<IDbInsert, RepoDbInsert>(provider => new RepoDbInsert(connectionString));
builder.Services.AddTransient<IDbUpdate, RepoDbUpdate>(provider => new RepoDbUpdate(connectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();