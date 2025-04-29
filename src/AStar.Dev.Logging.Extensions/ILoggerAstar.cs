namespace AStar.Dev.Logging.Extensions;

/// <summary>
///     The <see cref="ILoggerAstar{T}" /> adds specific log messages which, under the hood, use the LoggerMessage.Define method to specify the Log Format
/// </summary>
/// <typeparam name="T">The type of logger</typeparam>
public interface ILoggerAstar<out T> : ILogger<T>
{
    /// <summary>
    ///     The LogPageView method will log the page view using Application Insights Page View (if configured) as well as the logging provider(s) configured separately
    /// </summary>
    /// <param name="pageName">The name of the page being viewed</param>
    void LogPageView(string pageName);

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

    /// <summary>
    ///     The LogException method does exactly what its name says
    /// </summary>
    /// <param name="exception">An instance of the Exception (or derived type) that occurred</param>
    void LogException(Exception exception);

    /// <summary>
    ///     The LogCriticalFailure method does exactly what its name says
    /// </summary>
    /// <param name="exception">An instance of the Exception (or derived type) that occurred</param>
    void LogCriticalFailure(Exception exception);
}