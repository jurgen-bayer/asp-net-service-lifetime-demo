using Microsoft.AspNetCore.Mvc;
using ServiceLifetimeDemo.Model;
using ServiceLifetimeDemo.Services;

namespace ServiceLifetimeDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    private readonly ITransientCounterService transientCounterService;
    private readonly IScopedCounterService scopedCounterService;
    private readonly ISingletonCounterService singletonCounterService;
    private readonly IServiceUsingTransientCounterService serviceUsingTransientCounterService;
    private readonly IServiceUsingScopedCounterService serviceUsingScopedCounterService;
    private readonly IServiceUsingSingletonCounterService serviceUsingSingletonCounterService;

    public DemoController(
        ITransientCounterService transientCounterService,
        IScopedCounterService scopedCounterService,
        ISingletonCounterService singletonCounterService, 
        IServiceUsingTransientCounterService serviceUsingTransientCounterService, 
        IServiceUsingScopedCounterService serviceUsingScopedCounterService, 
        IServiceUsingSingletonCounterService serviceUsingSingletonCounterService)
    {
        this.transientCounterService = transientCounterService;
        this.scopedCounterService = scopedCounterService;
        this.singletonCounterService = singletonCounterService;
        this.serviceUsingTransientCounterService = serviceUsingTransientCounterService;
        this.serviceUsingScopedCounterService = serviceUsingScopedCounterService;
        this.serviceUsingSingletonCounterService = serviceUsingSingletonCounterService;
    }
    
    [HttpGet("transient")]
    public DemoResult GetDemoResultFromTransientService()
    {
        return new DemoResult
        {
            CountDirectlyFromCounterService = this.transientCounterService.Count,
            CountFromDemoServiceUsingCounterService = this.serviceUsingTransientCounterService.GetCount(),
            CounterServiceId = this.transientCounterService.Id,
            DemoServiceId = this.serviceUsingTransientCounterService.Id, 
        };
    }

    [HttpPost("transient")]
    public DemoResult AddCountToTransientService([FromBody] int number)
    {
        this.transientCounterService.Increase(number);
        return new DemoResult
        {
            CountDirectlyFromCounterService = this.transientCounterService.Count,
            CountFromDemoServiceUsingCounterService = this.serviceUsingTransientCounterService.GetCount(),
            CounterServiceId = this.transientCounterService.Id,
            DemoServiceId = this.serviceUsingTransientCounterService.Id, 
        };
    }
    
    [HttpGet("scoped")]
    public DemoResult GetDemoResultFromScopedService()
    {
        return new DemoResult
        {
            CountDirectlyFromCounterService = this.scopedCounterService.Count,
            CountFromDemoServiceUsingCounterService = this.serviceUsingScopedCounterService.GetCount(),
            CounterServiceId = this.scopedCounterService.Id,
            DemoServiceId = this.serviceUsingScopedCounterService.Id, 
        };
    }

    [HttpPost("scoped")]
    public DemoResult AddCountToScopedService([FromBody] int number)
    {
        this.scopedCounterService.Increase(number);
        return new DemoResult
        {
            CountDirectlyFromCounterService = this.scopedCounterService.Count,
            CountFromDemoServiceUsingCounterService = this.serviceUsingScopedCounterService.GetCount(),
            CounterServiceId = this.scopedCounterService.Id,
            DemoServiceId = this.serviceUsingScopedCounterService.Id, 
        };
    }
    
    [HttpGet("singleton")]
    public DemoResult GetDemoResultFromSingletonService()
    {
        return new DemoResult
        {
            CountDirectlyFromCounterService = this.singletonCounterService.Count,
            CountFromDemoServiceUsingCounterService = this.serviceUsingSingletonCounterService.GetCount(),
            CounterServiceId = this.singletonCounterService.Id,
            DemoServiceId = this.serviceUsingSingletonCounterService.Id, 
        };
    }

    [HttpPost("singleton")]
    public DemoResult AddCountToSingletonService([FromBody] int number)
    {
        this.singletonCounterService.Increase(number);
        return new DemoResult
        {
            CountDirectlyFromCounterService = this.singletonCounterService.Count,
            CountFromDemoServiceUsingCounterService = this.serviceUsingSingletonCounterService.GetCount(),
            CounterServiceId = this.singletonCounterService.Id,
            DemoServiceId = this.serviceUsingSingletonCounterService.Id, 
        };
    }
}