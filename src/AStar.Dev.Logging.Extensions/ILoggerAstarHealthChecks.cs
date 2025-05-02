using AStar.Dev.Api.HealthChecks;
using AStar.Dev.Functional.Extensions;

namespace AStar.Dev.Logging.Extensions;

public partial interface ILoggerAstar<out T>
{
    /// <summary>
    ///     The LogHealthCheckStart method logs the call (using the Debug level) to the HealthCheck for the specified API
    /// </summary>
    /// <param name="apiName">The name of the API being checked</param>
    void LogHealthCheckStart(string apiName);

    /// <summary>
    ///     The LogHealthCheckSuccess method logs the call (using the Debug level) to the HealthCheck for the specified API
    /// </summary>
    /// <param name="apiName">The name of the API being checked</param>
    void LogHealthCheckSuccess(string apiName);

    /// <summary>
    ///     The LogHealthCheckWarning method logs the call (using the Warning level) to the HealthCheck for the specified API
    /// </summary>
    /// <param name="apiName">The name of the API being checked</param>
    /// <param name="warningMessage">The warning message to log</param>
    void LogHealthCheckWarning(string apiName, string warningMessage);

    /// <summary>
    ///     The LogHealthCheckFailure method logs the call (using the Error level) to the HealthCheck for the specified API
    /// </summary>
    /// <param name="apiName">The name of the API being checked</param>
    /// <param name="failureMessage">The failure message to log</param>
    void LogHealthCheckFailure(string apiName, string failureMessage);
}
