namespace DiServiceRegistration;
public class Dependency3 : IDependency3
{
    private readonly IDependency4 dependency4;

    public Dependency3(IDependency4 dependency4)
    {
        this.dependency4 = dependency4;
    }
}
