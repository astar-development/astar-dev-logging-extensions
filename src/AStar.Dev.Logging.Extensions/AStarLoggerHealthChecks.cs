namespace AStar.Dev.Logging.Extensions;

public partial class AStarLogger<TCategoryName>
{
    /// <inheritdoc />
    public void LogHealthCheckStart(string apiName)
        => LoggerMessageDefinitionsHealthChecks.HealthCheckStart(logger, apiName, null);

    /// <inheritdoc />
    public void LogHealthCheckSuccess(string apiName)
        => LoggerMessageDefinitionsHealthChecks.HealthCheckSuccess(logger, apiName, null);

    /// <inheritdoc />
    public void LogHealthCheckWarning(string apiName, string warningMessage)
        => LoggerMessageDefinitionsHealthChecks.HealthCheckWarning(logger, apiName, warningMessage, null);

    /// <inheritdoc />
    public void LogHealthCheckFailure(string apiName, string failureMessage)
        => LoggerMessageDefinitionsHealthChecks.HealthCheckFailure(logger, apiName, failureMessage, null);
}