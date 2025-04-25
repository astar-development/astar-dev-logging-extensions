using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace AStar.Dev.Logging.Extensions;

/// <summary>
///     The <see cref="CloudRoleNameTelemetryInitializer" /> class implements the <see cref="ITelemetryInitializer" /> interface to add the Cloud Role Name to the Application Insights logging.
/// </summary>
/// <param name="roleOrApplicationName">The Role / Application Name to configure Application Insights with</param>
/// <param name="instrumentationKey">The Instrumentation Key to configure Application Insights with</param>
public sealed class CloudRoleNameTelemetryInitializer(string roleOrApplicationName, string instrumentationKey) : ITelemetryInitializer
{
    /// <inheritdoc />
    public void Initialize(ITelemetry telemetry)
    {
        try
        {
            telemetry.Context.Cloud.RoleName     = roleOrApplicationName;

            telemetry.Context.InstrumentationKey = instrumentationKey;
        }
        catch
        {
        }
    }
}
