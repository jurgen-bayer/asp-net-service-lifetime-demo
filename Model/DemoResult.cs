namespace ServiceLifetimeDemo.Model;

public class DemoResult
{
    public int CountDirectlyFromCounterService { get; set; }
    
    public int CountFromDemoServiceUsingCounterService { get; set; }

    public int CounterServiceId { get; set; }
    
    public int DemoServiceId { get; set; }
    
    public int DemoServiceCounterServiceId { get; set; }
}