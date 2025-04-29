namespace AStar.Dev.Logging.Extensions;

/// <summary>
///     The <see cref="AStarEventIds" /> class contains the defined <see cref="Microsoft.Extensions.Logging.EventId" /> events available for logging
///     Stand-alone <see cref="Microsoft.Extensions.Logging.EventId" /> events can be defined but care should be taken to avoid reusing the values used here
/// </summary>
public static class AStarEventIds
{
    /// <summary>
    ///     The <see cref="Ui" /> class defines, yep, the EventIds for logging UI-related errors
    /// </summary>
    public static class Ui
    {
        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging a page view
        /// </summary>
        public static EventId PageView => AStarEventIdList.PageView;
    }

    /// <summary>
    ///     The <see cref="Common" /> class defines, yep, the EventIds for logging Common (shared) errors
    /// </summary>
    public static class Common
    {
        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging an error
        /// </summary>
        public static EventId ExceptionId => AStarEventIdList.Error;

        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging a critical error
        /// </summary>
        public static EventId CriticalEventId => AStarEventIdList.CriticalError;
    }

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
    }
}