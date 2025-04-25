using Microsoft.ApplicationInsights;

namespace AStar.Dev.Logging.Extensions;

/// <summary>
///
/// </summary>
public interface IAStarTelemetryClient
{
    /// <summary>
    ///
    /// </summary>
    TelemetryClient TelemetryClient { get; }

    /// <summary>
    ///
    /// </summary>
    /// <param name="pageName"></param>
    void TrackPageView(string pageName);
}