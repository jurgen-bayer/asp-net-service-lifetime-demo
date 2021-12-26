namespace ServiceLifetimeDemo.Services;

public interface IServiceUsingScopedCounterService
{
    Guid Id { get; }
    
    int GetCount();
}