namespace _2024MAUI.Services;

public static class ServiceLocator
{
    private static Dictionary<Type, object> _services = new Dictionary<Type, object>();
    
    public static void RegisterService(Type serviceType, object service)
    {
        if (_services.ContainsKey(serviceType))
            throw new Exception("Такой сервис уже зарегистрирован");
        _services[serviceType] = service;
    }
    public static object GetService(Type serviceType)
    {
        return _services[serviceType];
    }
}