namespace AStar.Dev.Logging.Extensions;

/// <summary>
///     The <see cref="AStarEventIds" /> class contains the defined <see cref="Microsoft.Extensions.Logging.EventId" /> events available for logging
///     Stand-alone <see cref="Microsoft.Extensions.Logging.EventId" /> events can be defined but care should be taken to avoid reusing the values used here
/// </summary>
public static partial class AStarEventIds
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
}