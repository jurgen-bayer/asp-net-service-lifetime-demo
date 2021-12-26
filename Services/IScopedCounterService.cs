namespace ServiceLifetimeDemo.Services;

public interface IScopedCounterService
{ 
    int Id { get; }
    
    int Count { get; }

    void Increase(int number);
}