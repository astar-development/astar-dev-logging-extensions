namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// </summary>
public class LoggerMessageDefinitions
{
    /// <summary>
    ///     Defines the CriticalFailure message definition
    /// </summary>
    public Action<ILogger, string, Exception?> CriticalFailure => LoggerMessage.Define<string>(
                                                                                               LogLevel.Critical,
                                                                                               AStarEventIds.Common.ExceptionId,
                                                                                               "Critical failure: {ErrorMessage}");

    /// <summary>
    ///     Defines the ExceptionLogMessage message definition
    /// </summary>
    public Action<ILogger, string, Exception?> ExceptionLogMessage => LoggerMessage.Define<string>(
                                                                                                   LogLevel.Error,
                                                                                                   AStarEventIds.Common.ExceptionId,
                                                                                                   "Error: {ErrorMessage}");

    /// <summary>
    ///     Defines the HealthCheckFailure message definition
    /// </summary>
    public Action<ILogger, string,  string, Exception?> HealthCheckFailure => LoggerMessage.Define< string, string>(
                                                                                                                    LogLevel.Warning,
                                                                                                                    AStarEventIds.Api.HealthCheckFailure,
                                                                                                                    "HealthCheck Failure: {ApiName} - {FailureMessage}");

    /// <summary>
    ///     Defines the HealthCheckStart message definition
    /// </summary>
    public Action<ILogger, string, Exception?> HealthCheckStart => LoggerMessage.Define<string>(
                                                                                                LogLevel.Debug,
                                                                                                AStarEventIds.Api.HealthCheckStart,
                                                                                                "HealthCheck Start: {ApiName}");

    /// <summary>
    ///     Defines the HealthCheckSuccess message definition
    /// </summary>
    public Action<ILogger, string, Exception?> HealthCheckSuccess => LoggerMessage.Define<string>(
                                                                                                  LogLevel.Debug,
                                                                                                  AStarEventIds.Api.HealthCheckStart,
                                                                                                  "HealthCheck Success: {ApiName}");

    /// <summary>
    ///     Defines the HealthCheckWarning message definition
    /// </summary>
    public Action<ILogger, string, string, Exception?> HealthCheckWarning => LoggerMessage.Define< string, string>(
                                                                                                                   LogLevel.Warning,
                                                                                                                   AStarEventIds.Api.HealthCheckWarning,
                                                                                                                   "HealthCheck Warning: {ApiName} - {WarningMessage}");

    /// <summary>
    ///     Defines the PageViewLogMessage message definition
    /// </summary>
    public Action<ILogger, string, Exception?> PageViewLogMessage => LoggerMessage.Define<string>(
                                                                                                  LogLevel.Information,
                                                                                                  AStarEventIds.Ui.PageView,
                                                                                                  "Page view: {PageName}");
}