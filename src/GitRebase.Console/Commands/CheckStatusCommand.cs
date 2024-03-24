using System.Text.Json;

using HealthChecks.UI.Core;

using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace GitRebase.Commands;

internal class CheckStatusCommand : Command
{
    private readonly HealthCheckService _healthCheckService;

    public CheckStatusCommand(HealthCheckService healthCheckService)
    {
        Key = "status";
        _healthCheckService = healthCheckService;
    }

    public override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Checking health status...");

        HealthReport healthReport = await _healthCheckService.CheckHealthAsync(cancellationToken);
        UIHealthReport report = UIHealthReport.CreateFrom(healthReport);

        Console.WriteLine($"Health status is {JsonSerializer.Serialize(report)}");
    }
}
