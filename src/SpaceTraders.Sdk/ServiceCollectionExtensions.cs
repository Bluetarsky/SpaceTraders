using Microsoft.Extensions.DependencyInjection;

namespace SpaceTraders.Sdk;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSpaceTraders(this IServiceCollection serviceCollection)
    {
        return serviceCollection;
    }
}