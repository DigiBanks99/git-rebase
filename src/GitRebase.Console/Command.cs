namespace GitRebase;

internal abstract class Command
{
    public string Key { get; protected init; }

    public abstract Task ExecuteAsync(CancellationToken cancellationToken);
}
