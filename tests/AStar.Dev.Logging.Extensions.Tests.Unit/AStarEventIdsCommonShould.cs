using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(AStarEventIds.Common))]
public class AStarEventIdsCommonShould
{
    [Fact]
    public void ContainTheExpectedDebugEventId()
        => AStarEventIds.Common.DebugEventId.Id.ShouldBe(1);

    [Fact]
    public void ContainTheExpectedDebugName()
        => AStarEventIds.Common.DebugEventId.Name.ShouldBe("Debug");

    [Fact]
    public void ContainTheExpectedInformationIdEventId()
        => AStarEventIds.Common.InformationEventId.Id.ShouldBe(2);

    [Fact]
    public void ContainTheExpectedInformationIdName()
        => AStarEventIds.Common.InformationEventId.Name.ShouldBe("Information");

    [Fact]
    public void ContainTheExpectedExceptionIdEventId()
        => AStarEventIds.Common.ExceptionId.Id.ShouldBe(500);

    [Fact]
    public void ContainTheExpectedExceptionIdName()
        => AStarEventIds.Common.ExceptionId.Name.ShouldBe("Error");

    [Fact]
    public void ContainTheExpectedCriticalEventIdEventId()
        => AStarEventIds.Common.CriticalEventId.Id.ShouldBe(666);

    [Fact]
    public void ContainTheExpectedCriticalEventIdName()
        => AStarEventIds.Common.CriticalEventId.Name.ShouldBe("Critical Error");
}