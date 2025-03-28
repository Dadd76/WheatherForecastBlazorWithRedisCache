using WheatherForecastBlazorWithRedisCache.Components;
using StackExchange.Redis;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using WheatherForecastBlazorWithRedisCache;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
 
builder.Services.AddStackExchangeRedisCache(options =>
{
options.Configuration = builder.Configuration.GetConnectionString("Redis");
options.InstanceName  = "WeatherForcast_";
});

builder.Services.AddSingleton<WeatherForcastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
