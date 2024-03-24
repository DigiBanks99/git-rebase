using GitRebase;
using GitRebase.Commands;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder();
builder.Services
    .AddCommands()
    .AddHealthChecks();

IHost host = builder.Build();

await host.StartAsync();

CommandHandler commandHandler = host.Services.GetRequiredService<CommandHandler>();
Command? command = commandHandler.GetNextCommand();
while (command is not NullCommand)
{
    await command.ExecuteAsync(default);
    command = commandHandler.GetNextCommand();
}

await host.StopAsync();
