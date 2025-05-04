using AStar.Dev.Api.HealthChecks;
using CSharpFunctionalExtensions;

namespace AStar.Dev.Logging.Extensions;

/// <summary>
///     The <see cref="ILoggerAstar{T}" /> adds specific log messages which, under the hood, use the LoggerMessage.Define method to specify the Log Format
/// </summary>
/// <typeparam name="T">The type of logger</typeparam>
public partial interface ILoggerAstar<out T> : ILogger<T>
{
    /// <summary>
    ///     The LogDebug method does exactly what its name says
    /// </summary>
    /// <param name="message">The message to be logged</param>
    void LogDebug(string message);

    /// <summary>
    ///     The LogInformation method does exactly what its name says
    /// </summary>
    /// <param name="message">The message to be logged</param>
    void LogInformation(string message);

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
    ///     The ReturnLoggedFailure will log the Health Check failure and return the <see cref="HealthStatusResponse" /> object
    /// </summary>
    /// <param name="response">The instance of <see cref="HttpResponseMessage" /> from the original call</param>
    /// <param name="apiName">The name of the API being called</param>
    /// <returns>An instance of <see cref="HealthStatusResponse" /> appropriately configured</returns>
    HealthStatusResponse ReturnLoggedFailure(HttpResponseMessage response, string apiName);

    /// <summary>
    ///     The ReturnLoggedSuccess method will log the successful call and return the TResult response object
    /// </summary>
    /// <param name="result"></param>
    /// <param name="apiName">The name of the API being called</param>
    /// <param name="endpointName">The endpoint name of the call</param>
    /// <typeparam name="TResult"></typeparam>
    /// <returns>An instance of TResult appropriately configured</returns>
    TResult ReturnLoggedSuccess<TResult>(TResult result, string apiName, string endpointName);

    /// <summary>
    ///     The ReturnLoggedFailure method will log the failed call and return the TResult response object
    /// </summary>
    /// <param name="apiName">The name of the API being called</param>
    /// <param name="endpointName">The endpoint name of the call</param>
    /// <param name="failureMessage">A preconfigured error message to log</param>
    /// <typeparam name="TResult">The type of the result</typeparam>
    /// <returns>An instance of Result{string,TResult} appropriately configured</returns>
    Result<string, TResult> ReturnLoggedFailure<TResult>(string apiName, string endpointName, string failureMessage);
}