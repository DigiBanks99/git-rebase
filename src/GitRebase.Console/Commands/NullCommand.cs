namespace GitRebase.Commands;

internal class NullCommand : Command
{
    public NullCommand()
    {
        Key = "Null";
    }

    public static NullCommand Instance { get; } = new NullCommand();

    public override Task ExecuteAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}