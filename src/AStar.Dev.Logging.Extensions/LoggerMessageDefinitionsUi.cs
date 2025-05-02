namespace AStar.Dev.Logging.Extensions;

/// <summary>
/// </summary>
public static class LoggerMessageDefinitionsUi
{
    /// <summary>
    ///     Defines the PageViewLogMessage message definition
    /// </summary>
    public static Action<ILogger, string, Exception?> PageView => LoggerMessage.Define<string>(
                                                                                               LogLevel.Information,
                                                                                               AStarEventIds.Ui.PageView,
                                                                                               "Page view: {PageName}");
}