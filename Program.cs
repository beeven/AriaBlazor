using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using AriaBlazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();
//builder.Services.AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
builder.Services.AddSingleton<AriaBlazor.Services.TaskManagerFactory>();

await builder.Build().RunAsync();
