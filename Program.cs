using ConverterWebApplication;
using Converter_Web_Application.Service.Registrations.Cooking;
using Converter_Web_Application.Service.Registrations.Fuel;
using Converter_Web_Application.Service.Registrations.Travel;
using Converter_Web_Application.Service.Registrations.Unit;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Converter_Web_Application.ApiLayer;
using Converter_Web_Application.Service.Configuration;
using Converter_Web_Application.Service.Base;
using Converter_Web_Application.Service.Localization;
using Converter_Web_Application.Service.DataServices;
using Converter_Web_Application.Service;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

var environment = builder.Configuration["Environment"] ?? "Production";

Console.WriteLine(environment);


builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apimBaseUrl = builder.Configuration["ApimBaseUrl"] ?? "https://converterwebapplicationapi.developer.azure-api.net";
var subscriptionKey = builder.Configuration["ApimSubscriptionKey"] ?? "b000004824934bc5a3ab4a19aba5236c";

// Register HttpClient with the base address of the application
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });




// Register configuration API and Currency configuration services
builder.Services.AddScoped<IApiClient, ApiClient>();
builder.Services.AddScoped<ICurrencyApiService>(sp => new CurrencyApiService(sp.GetRequiredService<IApiClient>(), apimBaseUrl, subscriptionKey));
builder.Services.AddScoped<ICurrencyConversionService, CurrencyConversionService>();

// Register data prefetching service
builder.Services.AddScoped<DataPrefetchService>();

// Register translation service
builder.Services.AddScoped<TranslationService>();







// Register ConversionManagerService as a singleton and register all conversions
builder.Services.AddSingleton<ConversionManagerService>(sp =>
{
    var service = new ConversionManagerService();

    // Register Length conversions
    LengthConversions_registrations.Register(service);

    // Register Weight conversions
    WeightConversions_registrations.Register(service);

    // Register Volume conversions
    VolumeConversions_registrations.Register(service);

    // Register Temperature conversions
    TemperatureConversions_registrations.Register(service);

    // Register Area conversions
    AreaConversions_registrations.Register(service);

    // Register Time conversions
    TimeConversions_registrations.Register(service);

    // Register Digital storage conversions
    DigitalConversions_registrations.Register(service);

    // Register Speed conversions
    SpeedConversions_registrations.Register(service);

    // Register Cooking conversions
    SugarConversions_registrations.Register(service);
    FlourConversions_registrations.Register(service);
    ButterConversions_registrations.Register(service);
    MilkConversions_registrations.Register(service);
    RiceConversions_registrations.Register(service);
    WaterConversions_registrations.Register(service);

    // Register Travel conversions
    TravelConversionsRegistration.Register(service);

    // Register Fuel conversions
    FuelConversionsRegistration.Register(service);

    return service;
});

// Register the observer for currency conversion
builder.Services.AddScoped<CurrencyConversionObserver>();

var host = builder.Build();

// Initialize services and attach the observer to the currency conversion service
var currencyConversionService = host.Services.GetRequiredService<ICurrencyConversionService>();
var currencyObserver = host.Services.GetRequiredService<CurrencyConversionObserver>();
((CurrencyConversionService)currencyConversionService).Attach(currencyObserver);

// Initialize TranslationService
var translationService = host.Services.GetRequiredService<TranslationService>();
await translationService.InitializeAsync();

// Fetch currency data immediately after the app is loaded
var dataPrefetchService = host.Services.GetRequiredService<DataPrefetchService>();
_ = dataPrefetchService.LoadCurrencyDataAsync(); // Fire and forget

// Run the application
await host.RunAsync();
