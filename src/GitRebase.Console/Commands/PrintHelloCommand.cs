﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitRebase.Commands;

internal class PrintHelloCommand : Command
{
    public PrintHelloCommand()
    {
        Key = "hello";    
    }

    public override Task ExecuteAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine($"Hello! Learning Git Rebase I see 😀{Environment.NewLine}");
        return Task.CompletedTask;
    }
}
