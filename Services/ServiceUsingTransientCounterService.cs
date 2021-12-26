namespace ServiceLifetimeDemo.Services;

public class ServiceUsingTransientCounterService: IServiceUsingTransientCounterService
{
    private readonly ITransientCounterService counterService;

    public ServiceUsingTransientCounterService(ITransientCounterService counterService)
    {
        this.counterService = counterService;
    }
    
    public Guid Id { get; } = Guid.NewGuid();
    
    public int GetCount()
    {
        return this.counterService.Count;
    }
}