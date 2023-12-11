using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RestClient.AutoComplete.File.Abstractions;

namespace RestClient.AutoComplete.HostedServices;

public class StartingConfigurationService(
    ILogger<StartingConfigurationService> logger,
    IServiceScopeFactory serviceScopeFactory)
    : IHostedService
{
    private readonly ILogger<StartingConfigurationService> _logger = logger;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        using var scope = serviceScopeFactory.CreateScope();
        var fileCreator = scope.ServiceProvider.GetRequiredService<IFileCreator>();
        
        
        fileCreator.CreateFile("test.rest");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}