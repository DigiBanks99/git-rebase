using GitRebase.Commands;

namespace GitRebase;

internal class CommandHandler
{
    private readonly IEnumerable<Command> _commands;

    public CommandHandler(IEnumerable<Command> commands)
    {
        _commands = commands;
    }

    public Command GetNextCommand()
    {
        Console.Write("Please enter your next command: ");
        string? line = Console.ReadLine();

        if (line == null)
        {
            return NullCommand.Instance;
        }

        string? directive = line.Split(' ').FirstOrDefault();
        if (directive == null)
        {
            return new PrintErrorCommand(Error.NoDirective);
        }

        return _commands.FirstOrDefault(command => command.Key == directive) ?? NullCommand.Instance;
    }

    public Task ExecuteCommandAsync(Command command, CancellationToken cancellationToken)
    {
        return command.ExecuteAsync(cancellationToken);
    }
}
