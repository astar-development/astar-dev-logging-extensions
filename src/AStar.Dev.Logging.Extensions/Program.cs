using System.Diagnostics.CodeAnalysis;

namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// This class only exists to allow the project type to be set to 'Microsoft.NET.Sdk.Web'
/// (which makes the NuGet packages required just the ones to support the Serilog config
/// whilst ignoring the Framework requirements.
/// </summary>
[ExcludeFromCodeCoverage]
internal class Program
{
    private static void Main() => Console.WriteLine("Hello, World!");
}
