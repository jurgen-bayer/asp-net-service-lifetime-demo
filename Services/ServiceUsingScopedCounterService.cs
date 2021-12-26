using BlazorWebAssemblyServiceLifetimeDemo.Client.Services;

namespace ServiceLifetimeDemo.Services;

public class ServiceUsingScopedCounterService: IServiceUsingScopedCounterService
{
    private readonly IScopedCounterService counterService;

    public ServiceUsingScopedCounterService(IScopedCounterService counterService)
    {
        this.counterService = counterService;
    }

    public int Id { get; } = IdHelper.GetNextId();
    
    public int CounterServiceId => this.counterService.Id;

    public int GetCount()
    {
        return this.counterService.Count;
    }
}