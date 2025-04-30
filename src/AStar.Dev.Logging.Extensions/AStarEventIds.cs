namespace AStar.Dev.Logging.Extensions;

/// <summary>
///     The <see cref="AStarEventIds" /> class contains the defined <see cref="Microsoft.Extensions.Logging.EventId" /> events available for logging
///     Stand-alone <see cref="Microsoft.Extensions.Logging.EventId" /> events can be defined but care should be taken to avoid reusing the values used here
/// </summary>
public static partial class AStarEventIds
{
    /// <summary>
    ///     The <see cref="Api" /> class defines, yep, the EventIds for logging API-related errors
    /// </summary>
    public static class Api
    {
        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging a HealthCheck start
        /// </summary>
        public static EventId HealthCheckStart =>  AStarEventIdList.HealthCheckStart;

        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging a HealthCheck success
        /// </summary>
        public static EventId HealthCheckSuccess =>  AStarEventIdList.HealthCheckSuccess;

        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging a HealthCheck warning
        /// </summary>
        public static EventId HealthCheckWarning =>  AStarEventIdList.HealthCheckWarning;

        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging a HealthCheck failure
        /// </summary>
        public static EventId HealthCheckFailure =>  AStarEventIdList.HealthCheckFailure;

        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging an API Call success
        /// </summary>
        public static EventId ApiCallStart =>  AStarEventIdList.ApiCallStart;

        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging an API Call success
        /// </summary>
        public static EventId ApiCallSuccess =>  AStarEventIdList.ApiCallSuccess;

        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging an API Call warning
        /// </summary>
        public static EventId ApiCallWarning =>  AStarEventIdList.ApiCallWarning;

        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging an API Call failure
        /// </summary>
        public static EventId ApiCallFailure =>  AStarEventIdList.ApiCallFailure;
    }
}