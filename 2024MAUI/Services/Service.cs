namespace _2024MAUI.Services;

public static class Service<T>
{
    private static T _instance { get; set; }

    public static void RegisterService(T instance)
    {
        _instance = instance;
    }

    public static T GetInstance()
    {
        return _instance;
    }
}