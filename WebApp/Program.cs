using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Helpers.Repositories;
using WebApp.Helpers.Services;
using WebApp.Models.Contexts;
using WebApp.Models.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<IdentityContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("merketo")));
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("mereketo")));
builder.Services.AddScoped<AddressRepository>();
builder.Services.AddScoped<UserAddressRepository>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<UserAdminService>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<ProductTagRepository>();
builder.Services.AddScoped<TagRepository>();
builder.Services.AddScoped<ContactFormRepository>();
builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
    x.User.RequireUniqueEmail = true;

}).AddEntityFrameworkStores<IdentityContext>()
  .AddClaimsPrincipalFactory<CustomClaimsPrincipalFactory>();

builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/login";
    x.LogoutPath = "/";
    x.AccessDeniedPath = "/denied";
});

var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
