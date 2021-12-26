namespace ServiceLifetimeDemo.Services;

public interface IServiceUsingTransientCounterService
{
    Guid Id { get; }
    
    int GetCount();
}