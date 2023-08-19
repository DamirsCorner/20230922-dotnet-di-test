using Microsoft.Extensions.DependencyInjection;

namespace DiServiceRegistration;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddScoped<IDependency, Dependency>();
        services.AddScoped<IDependency1, Dependency1>();
        services.AddScoped<IDependency2, Dependency2>();
        services.AddScoped<IDependency3, Dependency3>();
        services.AddScoped<IDependency4, Dependency4>();
        return services;
    }
}
