using AStar.Dev.Api.HealthChecks;
using AStar.Dev.Functional.Extensions;

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

    /// <summary>
    ///     The LogApiCallStart method logs the call (using the Debug level) for the specified API
    /// </summary>
    /// <param name="apiName">The name of the API being called</param>
    /// <param name="uri">The URI being called</param>
    void LogApiCallStart(string apiName, string uri);

    /// <summary>
    ///     The LogApiCallSuccess method logs the call (using the Debug level) to the specified API
    /// </summary>
    /// <param name="apiName">The name of the API being called</param>
    /// <param name="uri">The URI being called</param>
    void LogApiCallSuccess(string apiName, string uri);

    /// <summary>
    ///     The LogApiCallWarning method logs the call (using the Warning level) for the specified API
    /// </summary>
    /// <param name="apiName">The name of the API being called</param>
    /// <param name="uri">The URI being called</param>
    /// <param name="warningMessage">The warning message to log</param>
    void LogApiCallWarning(string apiName, string uri, string warningMessage);

    /// <summary>
    ///     The LogApiCallFailed method logs the call (using the Error level) for the specified API
    /// </summary>
    /// <param name="apiName">The name of the API being called</param>
    /// <param name="uri">The URI being called</param>
    /// <param name="failureMessage">The failure message to log</param>
    void LogApiCallFailed(string apiName, string uri, string failureMessage);

    /// <summary>
    /// The ReturnLoggedFailure will log the Health Check failure and return the <see cref="HealthStatusResponse"/> object
    /// </summary>
    /// <param name="response">The instance of <see cref="HttpResponseMessage"/> from the original call</param>
    /// <param name="apiName">The name of the API being called</param>
    /// <returns>An instance of <see cref="HealthStatusResponse"/> appropriately configured</returns>
    HealthStatusResponse ReturnLoggedFailure(HttpResponseMessage response, string apiName);

    /// <summary>
    /// The ReturnLoggedSuccess method will log the successful call and return the TResult response object
    /// </summary>
    /// <param name="result"></param>
    /// <param name="apiName">The name of the API being called</param>
    /// <param name="endpointName">The endpoint name of the call</param>
    /// <typeparam name="TResult"></typeparam>
    /// <returns>An instance of TResult appropriately configured</returns>
    TResult ReturnLoggedSuccess<TResult>(TResult result, string apiName, string endpointName);

    /// <summary>
    /// The ReturnLoggedFailure method will log the failed call and return the TResult response object
    /// </summary>
    /// <param name="apiName">The name of the API being called</param>
    /// <param name="endpointName">The endpoint name of the call</param>
    /// <param name="failureMessage">A preconfigured error message to log</param>
    /// <typeparam name="TResult">The type of the result</typeparam>
    /// <returns>An instance of Result{string,TResult} appropriately configured</returns>
    Result<string, TResult> ReturnLoggedFailure<TResult>(string apiName, string endpointName, string failureMessage);
}