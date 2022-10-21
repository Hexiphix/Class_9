using System;
using Class_9.Dao;
using Class_9.Models;
using Class_9.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Class_9;

/// <summary>
///     Used for registration of new interfaces
/// </summary>
internal class Startup
{
    public IServiceProvider ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddLogging(builder =>
        {
            builder.AddConsole();
            builder.AddFile("app.log");
        });

        // Add new lines of code here to register any interfaces and concrete services you create
        services.AddTransient<IMainService, MainService>();
        services.AddSingleton<IRepository<Dog>>(_ => DataServiceFactory.GetRepositoryInstance<Dog, Repository<Dog>>());
        services.AddSingleton<IRepository<Cat>>(_ => DataServiceFactory.GetRepositoryInstance<Cat, Repository<Cat>>());

        return services.BuildServiceProvider();
    }
}
