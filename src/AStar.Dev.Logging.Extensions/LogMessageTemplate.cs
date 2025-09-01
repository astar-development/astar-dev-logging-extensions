using Microsoft.Extensions.Logging;

namespace AStar.Dev.Logging.Extensions;

/// <summary>
///     Provides static methods for logging specific HTTP-related events using strongly-typed logging templates.
/// </summary>
public static partial class LogMessageTemplate
{
    /// <summary>
    ///     Logs an informational message indicating that a specific page has been viewed.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="pageName">The name of the page that was viewed.</param>
    [LoggerMessage(EventId = 200, Level = LogLevel.Information, Message = "Page `{PageName}` viewed.")]
    public static partial void PageView(ILogger logger, string pageName);

    /// <summary>
    ///     Logs a warning message for a Bad Request (400) event, including the requested path.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="path">The path of the HTTP request that caused the Bad Request.</param>
    [LoggerMessage(EventId = 400, Level = LogLevel.Warning, Message = "Bad Request (400) for `{Path}`")]
    public static partial void BadRequest(ILogger logger, string path);

    /// <summary>
    ///     Logs a warning message for an Unauthorized (401) event, including the requested path.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="path">The path of the HTTP request that caused the Unauthorized access.</param>
    [LoggerMessage(EventId = 401, Level = LogLevel.Warning, Message = "Unauthorized (401) for `{Path}`")]
    public static partial void Unauthorized(ILogger logger, string path);

    /// <summary>
    ///     Logs a warning message for a Forbidden (403) event, including the requested path and user information.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="path">The path of the HTTP request that caused the Forbidden error.</param>
    /// <param name="user">The user associated with the HTTP request; defaults to "Not known" if not provided.</param>
    [LoggerMessage(EventId = 403, Level = LogLevel.Warning, Message = "Forbidden (403) for `{Path}` for user `{User}`")]
    public static partial void Forbidden(ILogger logger, string path, string user = "Not known");

    /// <summary>
    ///     Logs a warning message for a Not Found (404) event, including the requested path.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="path">The path of the HTTP request that resulted in the Not Found status.</param>
    [LoggerMessage(EventId = 404, Level = LogLevel.Warning, Message = "Not Found (404) for `{Path}`")]
    public static partial void NotFound(ILogger logger, string path);

    /// <summary>
    ///     Logs a warning message for a Conflict (409) event, including the requested path.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="path">The path of the HTTP request that caused the Conflict.</param>
    [LoggerMessage(EventId = 409, Level = LogLevel.Warning, Message = "Conflict (409) for `{Path}`")]
    public static partial void Conflict(ILogger logger, string path);

    /// <summary>
    ///     Logs a warning message for an Unprocessable Entity (422) event, including the requested path.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="path">The path of the HTTP request that caused the Unprocessable Entity.</param>
    [LoggerMessage(EventId = 422, Level = LogLevel.Warning, Message = "Unprocessable Entity (422) for `{Path}`")]
    public static partial void UnprocessableEntity(ILogger logger, string path);

    /// <summary>
    ///     Logs a warning message for a Too Many Requests (429) event, including the requested path.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="path">The path of the HTTP request that caused the Too Many Requests.</param>
    [LoggerMessage(EventId = 429, Level = LogLevel.Warning, Message = "Too Many Requests (429) for `{Path}`")]
    public static partial void TooManyRequests(ILogger logger, string path);

    /// <summary>
    ///     Logs an error message for an Internal Server Error (500) event, including the requested path.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="path">The path of the HTTP request that caused the Internal Server Error.</param>
    [LoggerMessage(EventId = 500, Level = LogLevel.Error, Message = "Internal Server Error (500) for `{Path}`")]
    public static partial void InternalServerError(ILogger logger, string path);

    /// <summary>
    ///     Logs an error message for a Bad Gateway (502) event, including the requested path.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="path">The path of the HTTP request that caused the Bad Gateway error.</param>
    [LoggerMessage(EventId = 502, Level = LogLevel.Error, Message = "Bad Gateway (502) for `{Path}`")]
    public static partial void BadGateway(ILogger logger, string path);

    /// <summary>
    ///     Logs an error message for a Service Unavailable (503) event, including the requested path.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="path">The path of the HTTP request that caused the Service Unavailable error.</param>
    [LoggerMessage(EventId = 503, Level = LogLevel.Error, Message = "Service Unavailable (503) for `{Path}`")]
    public static partial void ServiceUnavailable(ILogger logger, string path);

    /// <summary>
    ///     Logs an error message for a Gateway Timeout (504) event, including the requested path.
    /// </summary>
    /// <param name="logger">The logger to be used for logging the event.</param>
    /// <param name="path">The path of the HTTP request that caused the Gateway Timeout.</param>
    [LoggerMessage(EventId = 504, Level = LogLevel.Error, Message = "Gateway Timeout (504) for `{Path}`")]
    public static partial void GatewayTimeout(ILogger logger, string path);
}