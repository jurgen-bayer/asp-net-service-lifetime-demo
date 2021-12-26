namespace ServiceLifetimeDemo.Services;

public interface ITransientCounterService
{ 
    int Id { get; }

    int Count { get; }
    
    void Increase(int number);
}