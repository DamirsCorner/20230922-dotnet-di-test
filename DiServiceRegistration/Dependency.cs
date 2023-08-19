namespace DiServiceRegistration;
public class Dependency : IDependency
{
    private readonly IDependency1 dependency1;
    private readonly IDependency2 dependency2;

    public Dependency(IDependency1 dependency1, IDependency2 dependency2)
    {
        this.dependency1 = dependency1;
        this.dependency2 = dependency2;
    }
}
