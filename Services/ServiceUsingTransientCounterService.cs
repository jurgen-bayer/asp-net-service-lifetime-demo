using System.Runtime.CompilerServices;
using BlazorWebAssemblyServiceLifetimeDemo.Client.Services;

namespace ServiceLifetimeDemo.Services;

public class ServiceUsingTransientCounterService: IServiceUsingTransientCounterService
{
    private readonly ITransientCounterService counterService;

    public ServiceUsingTransientCounterService(ITransientCounterService counterService)
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