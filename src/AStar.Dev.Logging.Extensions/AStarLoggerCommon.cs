using AStar.Dev.Api.HealthChecks;
using AStar.Dev.Functional.Extensions;

namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// The <see cref="AStarLogger{TCategoryName}"/> class supplies the currently supported, predefined, Log Messages.
/// There is an additional <seealso cref="Log{TState}"/> method for any currently not implemented log message
/// </summary>
/// <param name="logger">The underlying instance of <see cref="ILogger{TCategoryName}"/> that will perform the actual logging</param>
/// <param name="telemetryClient">An instance of the <see cref="IAStarTelemetryClient"/> to perform the Application Insights-specific logging (e.g.: Page View)</param>
/// <typeparam name="TCategoryName">The Logging type</typeparam>
public partial class AStarLogger<TCategoryName>(ILogger<TCategoryName> logger, IAStarTelemetryClient telemetryClient) : ILoggerAstar<TCategoryName>
{
    /// <inheritdoc />
    public void LogException(Exception exception)
        => LoggerMessageDefinitionsCommon.ExceptionLogMessage(logger, exception.GetBaseException().Message, exception);

    /// <inheritdoc />
    public void LogCriticalFailure(Exception exception)
        => LoggerMessageDefinitionsCommon.CriticalFailure(logger, exception.GetBaseException().Message, exception);

    /// <inheritdoc />
    public HealthStatusResponse ReturnLoggedFailure(HttpResponseMessage response, string apiName)
    {
        LogHealthCheckFailure(apiName, response.ReasonPhrase ?? "Failure reason not known");

        return new() { Status = $"Health Check failed - {response.ReasonPhrase}." };
    }

    /// <inheritdoc />
    public T ReturnLoggedSuccess<T>(T result, string apiName, string endpointName)
    {
        LogApiCallSuccess(apiName, endpointName);

        return result;
    }

    /// <inheritdoc />
    public Result<string, T> ReturnLoggedFailure<T>(string apiName, string endpointName, string failureMessage)
    {
        LogApiCallFailed(apiName, endpointName, failureMessage);

        return Result<string, T>.Failure($"Call to {endpointName} failed with {failureMessage}")!;
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