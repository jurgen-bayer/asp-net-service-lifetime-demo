namespace ServiceLifetimeDemo.Services;

public interface ISingletonCounterService
{ 
    int Id { get; }
    
    int Count { get; }

    void Increase(int number);
}