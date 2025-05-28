using System;
using System.Collections.Generic;

public class ServiceLocator : IService
{
    private readonly Dictionary<Type, object> _services = new();

    public ServiceLocator(params (Type, object)[] services)
    {
        foreach (var (type, instance) in services)
            _services[type] = instance;
    }

    public void Register<T>(T service) where T : class
    {
        _services[typeof(T)] = service;
    }

    public T GetService<T>() where T : class
    {
        if (_services.TryGetValue(typeof(T), out var service))
            return service as T;
        throw new Exception($"Service {typeof(T)} not found");
    }
}