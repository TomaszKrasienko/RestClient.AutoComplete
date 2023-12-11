using Microsoft.Extensions.DependencyInjection;
using RestClient.AutoComplete.File;
using RestClient.AutoComplete.File.Abstractions;
using RestClient.AutoComplete.HostedServices;

namespace RestClient.AutoComplete.Configuration;

public static class Extensions
{
    public static IServiceCollection AddRestClientAutoComplete(this IServiceCollection services)
        => services
            .SetServices()
            .SetHostedService();
    

    private static IServiceCollection SetServices(this IServiceCollection services)
        => services.AddSingleton<IFileCreator, FileCreator>();

    private static IServiceCollection SetHostedService(this IServiceCollection services)
        => services.AddHostedService<StartingConfigurationService>();
}