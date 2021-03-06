
using Microsoft.EntityFrameworkCore;
using MyBlazorServerApp.Controllers;
using MyBlazorServerApp.Data;
using MyBlazorServerApp.Data.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<PortfolioDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

//Extend HSTS
builder.Services.AddHsts(options =>
{
    options.Preload = true;
    options.IncludeSubDomains = true;
    options.MaxAge = TimeSpan.FromDays(360);
});

//scoped services/controllers 
builder.Services.AddScoped<GuestEntriesController>();
builder.Services.AddScoped<StarwarsController>();
builder.Services.AddScoped<UserController>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //HSTS extended to one year
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapHub<ChatHub>(ChatHub.HubUrl);
app.Run();
