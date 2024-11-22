using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EmployeeTaskAttendanceUI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Adding the appsettings.json configuration file
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// Setting up HttpClient to use the API URL defined in appsettings.json
var backendApiUrl = builder.Configuration["BackendApiUrl"];
if (string.IsNullOrEmpty(backendApiUrl))
{
    throw new InvalidOperationException("BackendApiUrl is not set in appsettings.json");
}

// Registering HttpClient to use the backend API URL for API calls
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(backendApiUrl)
});

// Adding logging services for error and information logging
builder.Services.AddLogging(config => config.AddConsole());

await builder.Build().RunAsync();
