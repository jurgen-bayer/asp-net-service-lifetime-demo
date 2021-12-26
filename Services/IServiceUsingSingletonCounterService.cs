namespace ServiceLifetimeDemo.Services;

public interface IServiceUsingSingletonCounterService
{ 
    int Id { get; }
    
    int CounterServiceId { get; }

    int GetCount();
}