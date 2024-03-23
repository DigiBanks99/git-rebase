using Microsoft.Extensions.DependencyInjection;

namespace GitRebase.Commands;

internal static class CommandServiceCollectionExtensions
{
    public static IServiceCollection AddCommands(this IServiceCollection services)
    {
        services.AddSingleton<CommandHandler>();
        services.AddSingleton<Command, PrintHelloCommand>();
        return services;
    }
}
