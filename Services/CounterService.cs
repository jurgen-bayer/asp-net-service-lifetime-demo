namespace ServiceLifetimeDemo.Services;

public class CounterService: ITransientCounterService, IScopedCounterService, ISingletonCounterService
{
    public Guid Id { get; } = Guid.NewGuid();

    public int Count { get; private set;  }

    public void Increase(int number)
    {
        this.Count += number;
    }
}