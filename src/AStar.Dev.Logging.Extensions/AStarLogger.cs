using Microsoft.ApplicationInsights;

namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// </summary>
/// <param name="logger"></param>
/// <param name="telemetryClient"></param>
/// <typeparam name="TCategoryName"></typeparam>
public sealed class AStarLogger<TCategoryName>(ILogger<TCategoryName> logger, TelemetryClient telemetryClient) : ILoggerAstar<TCategoryName>
{
    private readonly Action<ILogger, string, Exception?> logMessage = LoggerMessage.Define<string>(
                                                                                                   LogLevel.Information,
                                                                                                   AStarEventIds.PageView,
                                                                                                   "Page view: {ItemName}");

    /// <inheritdoc />
    public void LogPageView(string pageName)
    {
        logMessage(logger, pageName, null);

        telemetryClient.TrackPageView(pageName);
    }

    /// <inheritdoc />
    public IDisposable? BeginScope<TState>(TState state)
        where TState : notnull
        => logger.BeginScope(state);

    /// <inheritdoc />
    public bool IsEnabled(LogLevel logLevel)
        => logger.IsEnabled(logLevel);

    /// <inheritdoc />
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        => logger.Log(logLevel, eventId, state, exception, formatter);
}