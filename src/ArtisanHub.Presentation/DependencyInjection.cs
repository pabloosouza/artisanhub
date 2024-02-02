using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace ArtisanHub.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers()
            .AddApplicationPart(Assembly.GetExecutingAssembly());

        return services;
    }
}