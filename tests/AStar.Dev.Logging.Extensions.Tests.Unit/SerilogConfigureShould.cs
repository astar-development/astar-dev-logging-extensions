using JetBrains.Annotations;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.AspNetCore.Builder;
using Serilog;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(SerilogConfigure))]
public class SerilogConfigureShould
{
    [Fact]
    public void ConfigureTheLoggerConfigurationAsExpected()
    {
        var builder                = WebApplication.CreateBuilder();
        var app                    = builder.AddSerilogLogging("helpers/serilog.json");
        var telemetryConfiguration = new TelemetryConfiguration();
        var loggerConfiguration    = new LoggerConfiguration();

        var sut                    = loggerConfiguration.Configure(app.Configuration, telemetryConfiguration);

        sut.WriteTo.ApplicationInsights(telemetryConfiguration, TelemetryConverter.Traces).ShouldNotBeNull();
    }
}