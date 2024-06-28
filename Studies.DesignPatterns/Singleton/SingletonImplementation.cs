namespace Studies.DesignPatterns.Singleton;

public class SingletonImplementation
{
    private static SingletonImplementation? Instance = null;

    public string? TestProperty { get; set; }

    private SingletonImplementation() { }

    public static SingletonImplementation GetInstance()
    {
        return Instance ??= Instance = new SingletonImplementation();
    }
}
