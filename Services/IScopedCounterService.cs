namespace ServiceLifetimeDemo.Services;

public interface IScopedCounterService
{ 
    Guid Id { get; }
    
    int Count { get; }

    void Increase(int number);
}