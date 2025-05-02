namespace AStar.Dev.Logging.Extensions;

public partial interface ILoggerAstar<out T>
{
    /// <summary>
    ///     The LogApiCallStart method logs the call (using the Debug level) for the specified API
    /// </summary>
    /// <param name="apiName">The name of the API being called</param>
    /// <param name="uri">The URI being called</param>
    void LogApiCallStart(string apiName, string uri);

    /// <summary>
    ///     The LogApiCallStart method logs the call (using the Debug level) for the specified API - including additional information
    /// </summary>
    /// <param name="apiName">The name of the API being called</param>
    /// <param name="uri">The URI being called</param>
    /// <param name="additionalInformation">Additional Information to log</param>
    void LogApiCallStart(string apiName, string uri, string additionalInformation);

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
}