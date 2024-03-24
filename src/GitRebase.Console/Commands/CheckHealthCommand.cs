using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace GitRebase.Commands;

internal class CheckHealthCommand : Command
{
    private readonly HealthCheckService _healthCheckService;

    public CheckHealthCommand(HealthCheckService healthCheckService)
    {
        Key = "health";
        _healthCheckService = healthCheckService;
    }

    public override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Checking health...");

        HealthReport healthReport = await _healthCheckService.CheckHealthAsync(cancellationToken);

        Console.WriteLine($"Health status is {healthReport.Status}");
    }
}
