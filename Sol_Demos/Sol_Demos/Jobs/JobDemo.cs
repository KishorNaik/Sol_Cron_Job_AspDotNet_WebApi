using CronScheduler.Extensions.Scheduler;

namespace Sol_Demos.Jobs;

public class JobDemo : IScheduledJob
{
    private readonly ILogger<JobDemo> _logger;

    public JobDemo(ILogger<JobDemo> logger)
    {
        _logger = logger;
    }

    public string Name { get; } = nameof(JobDemo);

    public Task ExecuteAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Running {name}", nameof(JobDemo));
        return Task.CompletedTask;
    }
}