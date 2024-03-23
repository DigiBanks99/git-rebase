// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder();

IHost host = builder.Build();

Console.WriteLine($"Hello! Learning Git Rebase I see 😀{Environment.NewLine}");

await host.RunAsync();
