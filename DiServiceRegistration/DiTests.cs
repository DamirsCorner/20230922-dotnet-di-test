using Microsoft.Extensions.DependencyInjection;

namespace DiServiceRegistration;

public class DiTests
{
    [Test]
    public void DependencyInstantiates()
    {
        var services = new ServiceCollection();
        services.AddDependencies();
        var serviceProvider = services.BuildServiceProvider();

        var dependency = serviceProvider.GetRequiredService<IDependency>();

        Assert.NotNull(dependency);
    }
}