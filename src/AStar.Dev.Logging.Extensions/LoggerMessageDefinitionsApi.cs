namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// </summary>
public static class LoggerMessageDefinitionsApi
{
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