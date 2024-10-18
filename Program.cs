using Microsoft.EntityFrameworkCore;
using ZAxisModule.Data;
using ZAxisModule.ModelVM;
using ZAxisModule.Repositories.abstractrepositories;
using ZAxisModule.Repositories.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddTransient<Extension>();
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseOracle(builder.Configuration.GetConnectionString("MyConnection"), b => b.UseOracleSQLCompatibility("11")));
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ILogin, Login>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

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
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Login}/{id?}");

app.Run();
