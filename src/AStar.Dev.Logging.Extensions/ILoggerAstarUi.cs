namespace AStar.Dev.Logging.Extensions;

public partial interface ILoggerAstar<out T>
{
    /// <summary>
    ///     The LogPageView method will log the page view using Application Insights Page View (if configured) as well as the logging provider(s) configured separately
    /// </summary>
    /// <param name="pageName">The name of the page being viewed</param>
    void LogPageView(string pageName);
}