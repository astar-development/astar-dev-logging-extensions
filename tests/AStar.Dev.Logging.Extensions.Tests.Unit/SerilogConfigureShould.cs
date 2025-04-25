using AStar.Dev.Logging.Extensions;
using AStar.Dev.Logging.Extensions.Models;
using AStar.Dev.Utilities;
using JetBrains.Annotations;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using NSubstitute;
using Serilog;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(SerilogConfigure))]
public class SerilogConfigureShould
{
    [Fact]
    public void ConfigureTheLoggerConfigurationAsExpected()
    {
        var builder    = WebApplication.CreateBuilder();
        var testConfig = new SerilogConfig { Serilog = { WriteTo = [new() { Args   = new() { ServerUrl = "https://example.com" } }] }, Logging = new Models.Logging(){}};
        File.WriteAllText("serilog.config", testConfig.ToJson()); // OK, not a true unit test but...

        var app        = builder.AddSerilogLogging("serilog.config");

        var telemetryConfiguration = new TelemetryConfiguration();
        var loggerConfiguration    = new LoggerConfiguration();
        var sut                    = loggerConfiguration.Configure(app.Configuration, telemetryConfiguration);

        sut.WriteTo.ApplicationInsights(telemetryConfiguration, TelemetryConverter.Traces).ShouldNotBeNull();
    }
}