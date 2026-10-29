using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TheMemoAnaGame;
using MudBlazor.Services;
using TheMemoAnaGame.Infrastructure.Services.Abstract;
using TheMemoAnaGame.Infrastructure.Services.Concrete;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources/Localization");
builder.Services.AddSingleton(typeof(ILocalizer<>), typeof(Localizer<>));
var app = builder.Build();
System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new ("pt-BR");
System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new ("pt-BR");
System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.DefaultThreadCurrentCulture;
System.Globalization.CultureInfo.CurrentUICulture = System.Globalization.CultureInfo.DefaultThreadCurrentUICulture;
await app.RunAsync();