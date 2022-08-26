using DependencyInjectionExampleTP;
using DependencyInjectionExampleTP.Process;
using DependencyInjectionExampleTP.Process.Interfaces;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        // IConfiguration configuration = hostContext.Configuration;
        // services.AddSingleton(configuration);
        //services.AddTransient<IEjecutarReq, EjecutarReq>();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
