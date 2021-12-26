namespace ServiceLifetimeDemo.Services;

public class ServiceUsingSingletonCounterService: IServiceUsingSingletonCounterService
{
    private readonly ISingletonCounterService counterService;

    public ServiceUsingSingletonCounterService(ISingletonCounterService counterService)
    {
        this.counterService = counterService;
    }

    public Guid Id { get; } = Guid.NewGuid();
    
    public int GetCount()
    {
        return this.counterService.Count;
    }
}