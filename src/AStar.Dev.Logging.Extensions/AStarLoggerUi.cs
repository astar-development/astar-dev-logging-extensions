namespace AStar.Dev.Logging.Extensions;

public partial class AStarLogger<TCategoryName>
{
    /// <inheritdoc />
    public void LogPageView(string pageName)
    {
        LoggerMessageDefinitionsUi.PageView(logger, pageName, null);

        telemetryClient.TrackPageView(pageName);
    }
}