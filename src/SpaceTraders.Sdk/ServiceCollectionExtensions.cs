using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SpaceTraders.Sdk;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSpaceTraders(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient<IHttpCommunicator, HttpCommunicator>(options =>
        {
            options.BaseAddress = new Uri("https://api.spacetraders.io/v2/");
        });
        
        return services;
    }
}