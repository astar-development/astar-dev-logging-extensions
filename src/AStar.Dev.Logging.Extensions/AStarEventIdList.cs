namespace AStar.Dev.Logging.Extensions;

/// <summary>
///     The <see cref="AStarEventIdList" /> class exists solely to collect the currently defined EventIds in one place to aid comprehension of the supported Ids
///     The <seealso cref="AStarEventIds" /> class exists (along with the nested classes) to expose the supported Ids for public consumption, grouped together into logical "chunks"
/// </summary>
internal static class AStarEventIdList
{
    public static readonly EventId Error              = new (500, "Error");
    public static readonly EventId CriticalError      = new (666, "Critical Error");
    public static readonly EventId PageView           = new (1_000, "Page View");
    public static readonly EventId HealthCheckStart   = new (2_000, "HealthCheck - Start");
    public static readonly EventId HealthCheckSuccess = new (2_001, "HealthCheck - Success");
    public static readonly EventId HealthCheckWarning = new (2_002, "HealthCheck - Warning");
    public static readonly EventId HealthCheckFailure = new (2_002, "HealthCheck - Failure");
}