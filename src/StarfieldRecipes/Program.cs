using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using StarfieldRecipes;
using StarfieldRecipes.Configuration;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var http = new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
};

builder.Services.AddScoped(_ => http);
builder.Services.AddMudServices();

using var response = await http.GetAsync("data.json");
await using var stream = await response.Content.ReadAsStreamAsync();

builder.Configuration.AddJsonStream(stream);
var recipesConfiguration = new RecipesConfiguration();
builder.Configuration.Bind("Recipes", recipesConfiguration);
builder.Services.AddSingleton(recipesConfiguration);
builder.Services.AddSingleton<Checklist>();

await builder.Build().RunAsync();
