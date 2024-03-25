namespace GitRebase.Commands;

internal class PrintHelpCommand : Command
{
    public PrintHelpCommand()
    {
        Key = "help";
    }

    public override Task ExecuteAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine(
            @"This is a simple console app that takes in a command and produces a certain output to the console

Commands:
\thello - Prints a welcoming message
\thelp - Prints this help message");
        return Task.CompletedTask;
    }
}