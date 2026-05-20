using SportMap.Web.Components;
using Microsoft.EntityFrameworkCore;
using SportMap.Infra;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? "Data Source=SportMap.db";

builder.Services.AddDbContextFactory<SportMapDbContext>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddScoped(sp =>
    sp.GetRequiredService<IDbContextFactory<SportMapDbContext>>().CreateDbContext());

builder.Services.AddScoped<IMoviesRepo, MoviesRepo>();
builder.Services.AddScoped<ICountriesRepo, CountriesRepo>();
builder.Services.AddScoped<ICurrenciesRepo, CurrenciesRepo>();
builder.Services.AddScoped<IMoneyRepo, MoneyRepo>();
builder.Services.AddScoped<ICountryCurrenciesRepo, CountryCurrenciesRepo>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddQuickGridEntityFrameworkAdapter();

var app = builder.Build();

using var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<SportMapDbContext>();
await new SeedDb(db, 100).Seed();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(
        typeof(SportMap.Todo.Todo).Assembly, 
        typeof(SportMap.Movie.Pages.MoviePages.Index).Assembly
    );

app.Run();
