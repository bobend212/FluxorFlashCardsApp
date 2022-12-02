using Blazored.LocalStorage;
using Fluxor;
using FluxorPlayground;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//add Fluxor
builder.Services.AddFluxor(config =>
{
    config.ScanAssemblies(typeof(Program).Assembly).UseReduxDevTools();
});

//Blazored.LocalStorage
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
