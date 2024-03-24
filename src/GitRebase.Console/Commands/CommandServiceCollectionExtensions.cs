using Microsoft.Extensions.DependencyInjection;

namespace GitRebase.Commands;

internal static class CommandServiceCollectionExtensions
{
    public static IServiceCollection AddCommands(this IServiceCollection services)
    {
        return services
            .AddSingleton<CommandHandler>()
            .AddSingleton<Command, CheckHealthCommand>()
            .AddSingleton<Command, CheckStatusCommand>()
            .AddSingleton<Command, PrintHelloCommand>();
    }
}
