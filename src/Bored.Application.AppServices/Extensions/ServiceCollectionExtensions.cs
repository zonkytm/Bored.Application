using Bored.Application.AppServices.Activities.Handlers;
using Bored.Application.AppServices.Contracts.Activities.Handlers;
using Bored.Application.AppServices.HttpClients;
using Microsoft.Extensions.DependencyInjection;

namespace Bored.Application.AppServices.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddHandlers(this IServiceCollection services)
    {
        services.AddScoped<IGetActivityHandler, GetActivityHandler>();
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        
    }

    public static void AddHttpService(this IServiceCollection services)
    {
        services.AddScoped<IBoredService, BoredService>();
    }

    public static void AddValidators(this IServiceCollection services)
    {
        
    }
}