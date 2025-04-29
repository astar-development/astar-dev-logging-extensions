namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// </summary>
/// <param name="loggerMessageDefinitions"></param>
/// <param name="logger"></param>
/// <param name="telemetryClient"></param>
/// <typeparam name="TCategoryName"></typeparam>
public class AStarLogger<TCategoryName>(LoggerMessageDefinitions loggerMessageDefinitions, ILogger<TCategoryName> logger, IAStarTelemetryClient telemetryClient) : ILoggerAstar<TCategoryName>
{
    /// <inheritdoc />
    public void LogPageView(string pageName)
    {
        loggerMessageDefinitions.PageViewLogMessage(logger, pageName, null);

        telemetryClient.TrackPageView(pageName);
    }

    /// <inheritdoc />
    public void LogHealthCheckStart(string apiName)
        => loggerMessageDefinitions.HealthCheckStart(logger, apiName, null);

    /// <inheritdoc />
    public void LogHealthCheckSuccess(string apiName)
        => loggerMessageDefinitions.HealthCheckSuccess(logger, apiName, null);

    /// <inheritdoc />
    public void LogHealthCheckWarning(string apiName, string warningMessage)
        => loggerMessageDefinitions.HealthCheckWarning(logger, apiName, warningMessage, null);

    /// <inheritdoc />
    public void LogHealthCheckFailure(string apiName, string failureMessage)
        => loggerMessageDefinitions.HealthCheckFailure(logger, apiName, failureMessage, null);

    /// <inheritdoc />
    public void LogException(Exception exception)
        => loggerMessageDefinitions.ExceptionLogMessage(logger, exception.GetBaseException().Message, exception);

    /// <inheritdoc />
    public void LogCriticalFailure(Exception exception)
        => loggerMessageDefinitions.CriticalFailure(logger, exception.GetBaseException().Message, exception);

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