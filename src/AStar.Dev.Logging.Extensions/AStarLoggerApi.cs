namespace AStar.Dev.Logging.Extensions;

public partial class AStarLogger<TCategoryName>
{
    /// <inheritdoc />
    public void LogApiCallStart(string apiName, string uri)
        => LoggerMessageDefinitionsApi.ApiCallStart(logger, apiName, uri, null);

    /// <inheritdoc />
    public void LogApiCallSuccess(string apiName, string uri)
        => LoggerMessageDefinitionsApi.ApiCallSuccess(logger, apiName, uri, null);

    /// <inheritdoc />
    public void LogApiCallWarning(string apiName, string uri, string warningMessage)
        => LoggerMessageDefinitionsApi.ApiCallWarning(logger, apiName, uri, warningMessage, null);

    /// <inheritdoc />
    public void LogApiCallFailed(string apiName, string uri, string failureMessage)
        => LoggerMessageDefinitionsApi.ApiCallFailure(logger, apiName, uri, failureMessage, null);
}