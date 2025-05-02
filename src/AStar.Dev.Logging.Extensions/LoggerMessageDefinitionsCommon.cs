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
                                                                                                      AStarEventIds.Common.CriticalEventId,
                                                                                                      "Critical failure: {ErrorMessage}");

    /// <summary>
    ///     Defines the ExceptionLogMessage message definition
    /// </summary>
    public static Action<ILogger, string, Exception?> ExceptionOccurred => LoggerMessage.Define<string>(
                                                                                                        LogLevel.Error,
                                                                                                        AStarEventIds.Common.ExceptionId,
                                                                                                        "Error: {ErrorMessage}");

    /// <summary>
    ///     Defines the ExceptionLogMessage message definition
    /// </summary>
    public static Action<ILogger, string, Exception?> Debug => LoggerMessage.Define<string>(
                                                                                            LogLevel.Error,
                                                                                            AStarEventIds.Common.DebugEventId,
                                                                                            "Error: {ErrorMessage}");

    /// <summary>
    ///     Defines the ExceptionLogMessage message definition
    /// </summary>
    public static Action<ILogger, string, Exception?> Information => LoggerMessage.Define<string>(
                                                                                                  LogLevel.Error,
                                                                                                  AStarEventIds.Common.InformationEventId,
                                                                                                  "Error: {ErrorMessage}");
}