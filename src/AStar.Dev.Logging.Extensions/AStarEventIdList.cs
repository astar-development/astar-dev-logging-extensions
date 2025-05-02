namespace AStar.Dev.Logging.Extensions;

/// <summary>
///     The <see cref="AStarEventIdList" /> class exists solely to collect the currently defined EventIds in one place to aid comprehension of the supported Ids
///     The <seealso cref="AStarEventIds" /> class exists (along with the nested classes) to expose the supported Ids for public consumption, grouped together into logical "chunks"
/// </summary>
internal static class AStarEventIdList
{
    public static readonly EventId Debug              = new (1, "Debug");
    public static readonly EventId Information        = new (2, "Information");
    public static readonly EventId Error              = new (500, "Error");
    public static readonly EventId CriticalError      = new (666, "Critical Error");
    public static readonly EventId PageView           = new (1_000, "Page View");
    public static readonly EventId HealthCheckStart   = new (2_000, "HealthCheck - Start");
    public static readonly EventId HealthCheckSuccess = new (2_001, "HealthCheck - Success");
    public static readonly EventId HealthCheckWarning = new (2_002, "HealthCheck - Warning");
    public static readonly EventId HealthCheckFailure = new (2_003, "HealthCheck - Failure");
    public static readonly EventId ApiCallStart       = new (2_004, "ApiCall - Start");
    public static readonly EventId ApiCallSuccess     = new (2_005, "ApiCall - Success");
    public static readonly EventId ApiCallWarning     = new (2_006, "ApiCall - Warning");
    public static readonly EventId ApiCallFailure     = new (2_007, "ApiCall - Failure");
}