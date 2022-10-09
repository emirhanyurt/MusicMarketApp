
using Microsoft.EntityFrameworkCore;
using MusicMarketBussines.Contracts;
using MusicMarketBussines.Implementation;
using MusicMarketCommon.Mappings;
using MusicMarketCore.Contracts;
using MusicMarketCore.DbModels;
using MusicMarketCore.Implementation;
using MusicMarketUI.Extentions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>(opt => 
opt.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection")));
builder.Services.AddApplicationService();
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
