namespace ServiceLifetimeDemo.Services;

public interface IServiceUsingTransientCounterService
{
    int Id { get; }
    
    int CounterServiceId { get; }

    int GetCount();
}