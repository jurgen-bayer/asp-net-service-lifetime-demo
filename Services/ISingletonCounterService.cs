namespace ServiceLifetimeDemo.Services;

public interface ISingletonCounterService
{ 
    Guid Id { get; }
    
    int Count { get; }

    void Increase(int number);
}