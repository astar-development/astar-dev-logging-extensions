using AStar.Dev.Api.HealthChecks;
using AStar.Dev.Functional.Extensions;

namespace AStar.Dev.Logging.Extensions;

public partial class AStarLogger<TCategoryName>
{
    /// <inheritdoc />
    public void LogHealthCheckStart(string apiName)
        => LoggerMessageDefinitionsApi.HealthCheckStart(logger, apiName, null);

    /// <inheritdoc />
    public void LogHealthCheckSuccess(string apiName)
        => LoggerMessageDefinitionsApi.HealthCheckSuccess(logger, apiName, null);

    /// <inheritdoc />
    public void LogHealthCheckWarning(string apiName, string warningMessage)
        => LoggerMessageDefinitionsApi.HealthCheckWarning(logger, apiName, warningMessage, null);

    /// <inheritdoc />
    public void LogHealthCheckFailure(string apiName, string failureMessage)
        => LoggerMessageDefinitionsApi.HealthCheckFailure(logger, apiName, failureMessage, null);
}