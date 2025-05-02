namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// </summary>
public static class LoggerMessageDefinitionsCommon
{
    /// <summary>
    ///     Defines the CriticalFailure message definition
    /// </summary>
    public static Action<ILogger, string, Exception?> CriticalFailure => LoggerMessage.Define<string>(
                                                                                                      LogLevel.Critical,
                                                                                                      AStarEventIds.Common.ExceptionId,
                                                                                                      "Critical failure: {ErrorMessage}");

    /// <summary>
    ///     Defines the ExceptionLogMessage message definition
    /// </summary>
    public static Action<ILogger, string, Exception?> ExceptionOccurred => LoggerMessage.Define<string>(
                                                                                                        LogLevel.Error,
                                                                                                        AStarEventIds.Common.ExceptionId,
                                                                                                        "Error: {ErrorMessage}");
}