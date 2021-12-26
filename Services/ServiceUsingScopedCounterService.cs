namespace ServiceLifetimeDemo.Services;

public class ServiceUsingScopedCounterService: IServiceUsingScopedCounterService
{
    private readonly IScopedCounterService counterService;

    public ServiceUsingScopedCounterService(IScopedCounterService counterService)
    {
        this.counterService = counterService;
    }

    public Guid Id { get; } = Guid.NewGuid();

    public int GetCount()
    {
        return this.counterService.Count;
    }
}