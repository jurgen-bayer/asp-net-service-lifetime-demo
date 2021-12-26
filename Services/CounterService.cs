using BlazorWebAssemblyServiceLifetimeDemo.Client.Services;

namespace ServiceLifetimeDemo.Services;

public class CounterService: ITransientCounterService, IScopedCounterService, ISingletonCounterService
{
    public int Id { get; } = IdHelper.GetNextId();

    public int Count { get; private set;  }

    public void Increase(int number)
    {
        this.Count += number;
    }
}