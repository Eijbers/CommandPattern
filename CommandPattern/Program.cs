using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CommandPattern.AntiPattern.Query;
using CommandPattern.AntiPattern.Login;
using CommandPattern.AntiPattern.Logout;
using CommandPattern.DIReporting;
using CommandPattern.AntiPattern;
using CommandPattern.CommandPattern;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<IQuery, Query>();
builder.Services.AddScoped<ILogin, Login>();
builder.Services.AddSingleton<ILogout, Logout>();
builder.Services.AddTransient<ServiceLifetimeReporter>();

//Antipattern DI
builder.Services.AddSingleton<HandleRequestAntiPattern>();

//Command pattern DI
builder.Services.AddSingleton<RequestHandler>();


using IHost host = builder.Build();

ExemplifyServiceLifetime(host.Services, "Lifetime 1");
ExemplifyServiceLifetime(host.Services, "Lifetime 2");

await host.RunAsync();

static void ExemplifyServiceLifetime(IServiceProvider hostProvider, string lifetime)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();
    logger.ReportServiceLifetimeDetails(
        $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeReporter>()");

    Console.WriteLine("...");

    logger = provider.GetRequiredService<ServiceLifetimeReporter>();
    logger.ReportServiceLifetimeDetails(
        $"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeReporter>()");

    Console.WriteLine();
}