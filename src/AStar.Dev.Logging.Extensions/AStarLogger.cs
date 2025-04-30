namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// The <see cref="AStarLogger{TCategoryName}"/> class supplies the currently supported, predefined, Log Messages.
/// There is an additional <seealso cref="Log{TState}"/> method for any currently not implemented log message
/// </summary>
/// <param name="logger">The underlying instance of <see cref="ILogger{TCategoryName}"/> that will perform the actual logging</param>
/// <param name="telemetryClient">An instance of the <see cref="IAStarTelemetryClient"/> to perform the Application Insights-specific logging (e.g.: Page View)</param>
/// <typeparam name="TCategoryName">The Logging type</typeparam>
public class AStarLogger<TCategoryName>(ILogger<TCategoryName> logger, IAStarTelemetryClient telemetryClient) : ILoggerAstar<TCategoryName>
{
    /// <inheritdoc />
    public void LogPageView(string pageName)
    {
        LoggerMessageDefinitionsUi.PageViewLogMessage(logger, pageName, null);

        telemetryClient.TrackPageView(pageName);
    }

    /// <inheritdoc />
    public void LogHealthCheckStart(string apiName)
        => LoggerMessageDefinitionsApi.HealthCheckStart(logger, apiName, null);

    /// <inheritdoc />
    public void LogHealthCheckSuccess(string apiName)
        => LoggerMessageDefinitionsApi.HealthCheckSuccess(logger, apiName, null);

    /// <inheritdoc />
    public void LogHealthCheckWarning(string apiName, string warningMessage)
        => LoggerMessageDefinitionsApi.HealthCheckWarning(logger, apiName, warningMessage, null);

    /// <inheritdoc />
    public void LogHealthCheckFailure(string apiName, string failureMessage)
        => LoggerMessageDefinitionsApi.HealthCheckFailure(logger, apiName, failureMessage, null);

    /// <inheritdoc />
    public void LogException(Exception exception)
        => LoggerMessageDefinitionsCommon.ExceptionLogMessage(logger, exception.GetBaseException().Message, exception);

    /// <inheritdoc />
    public void LogCriticalFailure(Exception exception)
        => LoggerMessageDefinitionsCommon.CriticalFailure(logger, exception.GetBaseException().Message, exception);

    /// <inheritdoc />
    public void LogApiCallStart(string apiName, string uri)
        => LoggerMessageDefinitionsApi.ApiCallStart(logger, apiName, uri, null);

    /// <inheritdoc />
    public void LogApiCallSuccess(string apiName, string uri)
        => LoggerMessageDefinitionsApi.ApiCallSuccess(logger, apiName, uri, null);

    /// <inheritdoc />
    public void LogApiCallWarning(string apiName, string uri, string warningMessage)
        => LoggerMessageDefinitionsApi.ApiCallWarning(logger, apiName, uri, warningMessage, null);

    /// <inheritdoc />
    public void LogApiCallFailed(string apiName, string uri, string failureMessage)
        => LoggerMessageDefinitionsApi.ApiCallFailure(logger, apiName, uri, failureMessage, null);

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