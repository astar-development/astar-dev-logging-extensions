using AStar.Dev.Logging.Extensions.Models;
using AStar.Dev.Utilities;
using Microsoft.AspNetCore.Builder;

namespace AStar.Dev.Logging.Extensions.Unit.Tests;

public class LoggingExtensionsShould
{
    [Theory]
    [InlineData(null)]
    [InlineData("This is not a valid filename for a lot of reasons")]
    [InlineData("c:\\This is not a valid filename\\as the path\\and filename\\do not exist.what.did.you.expect.lol")]
    public void ThrowExceptionWhenAddSerilogLoggingIsCalledButConfigIsntValid(string? fileNameWithPath)
    {
        var builder = WebApplication.CreateBuilder();

        Action action = () => LoggingExtensions.AddSerilogLogging(builder, fileNameWithPath!);

        _ = action.Should().Throw<Exception>();
    }

    [Fact]
    public void AddTheExpectedNumberOfSerilogServices()
    {
        var builder = WebApplication.CreateBuilder();
        var expectedServiceCount =147;
        var testConfig = new SerilogConfig();
        testConfig.Serilog.WriteTo = [new() { Args = new() { ServerUrl = "https://example.com" } }];
        File.WriteAllText("serilig.config", testConfig.ToJson()); // OK, not a true unit test but...

        var sut = LoggingExtensions.AddSerilogLogging(builder, "serilig.config");

        _ = sut.Services.Count(d => d.ServiceType.FullName?.StartsWith("Serilog") == false).Should().Be(expectedServiceCount);
    }
}
