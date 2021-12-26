using ServiceLifetimeDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add three service instances based on the same class but with different lifetimes
builder.Services.AddTransient<ITransientCounterService, CounterService>();
builder.Services.AddScoped<IScopedCounterService, CounterService>();
builder.Services.AddSingleton<ISingletonCounterService, CounterService>();
builder.Services.AddTransient<IServiceUsingTransientCounterService, ServiceUsingTransientCounterService>();
builder.Services.AddScoped<IServiceUsingScopedCounterService, ServiceUsingScopedCounterService>();
builder.Services.AddSingleton<IServiceUsingSingletonCounterService, ServiceUsingSingletonCounterService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");
;

app.Run();