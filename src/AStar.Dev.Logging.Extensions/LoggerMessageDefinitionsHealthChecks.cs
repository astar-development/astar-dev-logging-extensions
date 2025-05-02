namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// </summary>
public static class LoggerMessageDefinitionsHealthChecks
{
    /// <summary>
    ///     Defines the HealthCheckFailure message definition
    /// </summary>
    public static Action<ILogger, string,  string, Exception?> HealthCheckFailure => LoggerMessage.Define< string, string>(
                                                                                                                           LogLevel.Warning,
                                                                                                                           AStarEventIds.Api.HealthCheckFailure,
                                                                                                                           "HealthCheck Failure: {ApiName} - {FailureMessage}");

    /// <summary>
    ///     Defines the HealthCheckStart message definition
    /// </summary>
    public static Action<ILogger, string, Exception?> HealthCheckStart => LoggerMessage.Define<string>(
                                                                                                       LogLevel.Debug,
                                                                                                       AStarEventIds.Api.HealthCheckStart,
                                                                                                       "HealthCheck Start: {ApiName}");

    /// <summary>
    ///     Defines the HealthCheckSuccess message definition
    /// </summary>
    public static Action<ILogger, string, Exception?> HealthCheckSuccess => LoggerMessage.Define<string>(
                                                                                                         LogLevel.Debug,
                                                                                                         AStarEventIds.Api.HealthCheckStart,
                                                                                                         "HealthCheck Success: {ApiName}");

    /// <summary>
    ///     Defines the HealthCheckWarning message definition
    /// </summary>
    public static Action<ILogger, string, string, Exception?> HealthCheckWarning => LoggerMessage.Define<string, string>(
                                                                                                                         LogLevel.Warning,
                                                                                                                         AStarEventIds.Api.HealthCheckWarning,
                                                                                                                         "HealthCheck Warning: {ApiName} - {WarningMessage}");
}