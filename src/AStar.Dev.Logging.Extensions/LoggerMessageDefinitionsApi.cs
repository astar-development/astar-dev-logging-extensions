namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// </summary>
public static class LoggerMessageDefinitionsApi
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

    /// <summary>
    ///     Defines the ApiCallFailure message definition
    /// </summary>
    public static Action<ILogger, string, string,  string, Exception?> ApiCallFailure => LoggerMessage.Define< string, string, string>(
                                                                                                                                       LogLevel.Warning,
                                                                                                                                       AStarEventIds.Api.ApiCallFailure,
                                                                                                                                       "APICall Failure: {ApiName} - {URI} - {FailureMessage}");

    /// <summary>
    ///     Defines the ApiCallStart message definition
    /// </summary>
    public static Action<ILogger, string, string, Exception?> ApiCallStart => LoggerMessage.Define<string, string>(
                                                                                                                   LogLevel.Debug,
                                                                                                                   AStarEventIds.Api.ApiCallStart,
                                                                                                                   "APICall Start: {ApiName} - {URI}");

    /// <summary>
    ///     Defines the ApiCallSuccess message definition
    /// </summary>
    public static Action<ILogger, string, string, Exception?> ApiCallSuccess => LoggerMessage.Define<string, string>(
                                                                                                                     LogLevel.Debug,
                                                                                                                     AStarEventIds.Api.ApiCallSuccess,
                                                                                                                     "APICall Success: {ApiName} - {URI}");

    /// <summary>
    ///     Defines the ApiCallWarning message definition
    /// </summary>
    public static Action<ILogger, string, string, string, Exception?> ApiCallWarning => LoggerMessage.Define< string, string, string>(
                                                                                                                                      LogLevel.Warning,
                                                                                                                                      AStarEventIds.Api.HealthCheckWarning,
                                                                                                                                      "APICall Warning: {ApiName} - {URI} - {WarningMessage}");
}