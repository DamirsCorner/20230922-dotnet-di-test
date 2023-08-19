namespace DiServiceRegistration;
public class Dependency1 : IDependency1
{
    private readonly IDependency3 dependency3;

    public Dependency1(IDependency3 dependency3)
    {
        this.dependency3 = dependency3;
    }
}
