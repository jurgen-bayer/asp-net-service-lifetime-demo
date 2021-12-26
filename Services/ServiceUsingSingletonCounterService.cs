using BlazorWebAssemblyServiceLifetimeDemo.Client.Services;

namespace ServiceLifetimeDemo.Services;

public class ServiceUsingSingletonCounterService: IServiceUsingSingletonCounterService
{
    private readonly ISingletonCounterService counterService;

    public ServiceUsingSingletonCounterService(ISingletonCounterService counterService)
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