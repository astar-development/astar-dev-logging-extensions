using AStar.Dev.Logging.Extensions.Models;
using AStar.Dev.Utilities;
using Microsoft.ApplicationInsights.Extensibility;
using Serilog;

namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// The <see cref="LoggingExtensions" /> class contains, as you might expect, extension methods for configuring Serilog / Application Insights.
/// </summary>
public static class LoggingExtensions
{
    /// <summary>
    /// The <see cref="AddSerilogLogging" /> method will add Serilog to the logging providers.
    /// </summary>
    /// <param name="builder">
    /// </param>
    /// <param name="externalSettingsFile">
    /// The name (including extension) of the file containing the Serilog Configuration settings.
    /// </param>
    /// <returns>
    /// The original instance of <see cref="WebApplicationBuilder" /> for further method chaining.
    /// </returns>
    public static WebApplicationBuilder AddSerilogLogging(this WebApplicationBuilder builder, string externalSettingsFile = "")
    {
        if(externalSettingsFile.IsNotNullOrWhiteSpace())
        {
            _ = builder.Configuration.AddJsonFile(path: externalSettingsFile, optional: false, reloadOnChange: true);
        }

        _ = builder.Configuration.AddUserSecrets<Program>();

        _ = builder.Services.AddApplicationInsightsTelemetry();
        var serviceProvider = builder.Services.BuildServiceProvider();
        var seqServerUrl = builder.Configuration.Get<SerilogConfig>()!.Serilog.WriteTo[0].Args.ServerUrl;
        var logger = new LoggerConfiguration()
            .WriteTo.ApplicationInsights(serviceProvider.GetRequiredService<TelemetryConfiguration>(), TelemetryConverter.Traces)
            .WriteTo.Console()
            .WriteTo.Seq(seqServerUrl)
            .CreateLogger();

        logger.Debug("Serilog has been configured.");

        Log.Logger = logger;

        _ = builder.Host
                    .UseSerilog((context, loggerConfig) => loggerConfig
                    .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {Message:lj}{NewLine}{Exception}")
                    .ReadFrom.Configuration(context.Configuration)
                    .Enrich.FromLogContext());

        return builder;
    }
}
