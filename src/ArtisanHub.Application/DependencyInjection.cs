using ArtisanHub.Application.Features.Users.Commands.Create;
using Microsoft.Extensions.DependencyInjection;

namespace ArtisanHub.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(CreateUserCommand).Assembly));

        return services;
    }
}