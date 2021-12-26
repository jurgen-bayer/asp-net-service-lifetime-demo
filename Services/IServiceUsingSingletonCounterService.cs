namespace ServiceLifetimeDemo.Services;

public interface IServiceUsingSingletonCounterService
{ 
    Guid Id { get; }
    
    int GetCount();
}