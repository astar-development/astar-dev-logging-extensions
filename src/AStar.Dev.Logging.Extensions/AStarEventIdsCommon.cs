namespace AStar.Dev.Logging.Extensions;

/// <summary>
///     The <see cref="AStarEventIds" /> class contains the defined <see cref="Microsoft.Extensions.Logging.EventId" /> events available for logging
///     Stand-alone <see cref="Microsoft.Extensions.Logging.EventId" /> events can be defined but care should be taken to avoid reusing the values used here
/// </summary>
public static partial class AStarEventIds
{
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

        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging a critical error
        /// </summary>
        public static EventId DebugEventId => AStarEventIdList.Debug;

        /// <summary>
        ///     Gets the <see cref="EventId" /> preconfigured for logging a critical error
        /// </summary>
        public static EventId InformationEventId => AStarEventIdList.Information;
    }
}