
namespace GitRebase;

internal class PrintErrorCommand : Command
{
    private readonly Error _error;

    public PrintErrorCommand(Error error)
    {
        Key = "PrintError";
        _error = error;
    }

    public override Task ExecuteAsync(CancellationToken cancellationToken)
    {
        return _error switch
        {
            Error.NoDirective => Console.Error.WriteLineAsync("Unknown command received"),
            _ => Task.CompletedTask
        };
    }
}