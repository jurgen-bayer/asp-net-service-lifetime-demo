namespace ServiceLifetimeDemo.Services;

public interface ITransientCounterService
{ 
    Guid Id { get; }

    int Count { get; }
    
    void Increase(int number);
}