using System.Diagnostics.CodeAnalysis;
using Microsoft.ApplicationInsights;

namespace AStar.Dev.Logging.Extensions;

/// <summary>
///     This class exists to enable testing of the underlying functionality - it acts solely as a wrapper to <see cref="TelemetryClient" />
/// </summary>
/// <param name="telemetryClient"></param>
[ExcludeFromCodeCoverage]
public sealed class AStarTelemetryClient(TelemetryClient telemetryClient) : IAStarTelemetryClient
{
    /// <inheritdoc />
    public TelemetryClient TelemetryClient => telemetryClient;

    /// <inheritdoc />
    public void TrackPageView(string pageName)
        => telemetryClient.TrackPageView(pageName);
}