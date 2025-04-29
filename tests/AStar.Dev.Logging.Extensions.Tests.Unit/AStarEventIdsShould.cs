using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(AStarEventIds))]
public class AStarEventIdsShould
{
    [Fact]
    public void ContainTheExpectedPageViewEventId()
        => AStarEventIds.Ui.PageView.Id.ShouldBe(1_000);

    [Fact]
    public void ContainTheExpectedPageViewName()
        => AStarEventIds.Ui.PageView.Name.ShouldBe("Page View");

    [Fact]
    public void ContainTheExpectedHealthCheckStartEventId()
        => AStarEventIds.Api.HealthCheckStart.Id.ShouldBe(2_000);

    [Fact]
    public void ContainTheExpectedHealthCheckStartName()
        => AStarEventIds.Api.HealthCheckStart.Name.ShouldBe("HealthCheck - Start");

    [Fact]
    public void ContainTheExpectedHealthCheckSuccessEventId()
        => AStarEventIds.Api.HealthCheckSuccess.Id.ShouldBe(2_001);

    [Fact]
    public void ContainTheExpectedHealthCheckSuccessName()
        => AStarEventIds.Api.HealthCheckSuccess.Name.ShouldBe("HealthCheck - Success");

    [Fact]
    public void ContainTheExpectedHealthCheckWarningEventId()
        => AStarEventIds.Api.HealthCheckWarning.Id.ShouldBe(2_002);

    [Fact]
    public void ContainTheExpectedHealthCheckWarningName()
        => AStarEventIds.Api.HealthCheckWarning.Name.ShouldBe("HealthCheck - Warning");

    [Fact]
    public void ContainTheExpectedHealthCheckFailureEventId()
        => AStarEventIds.Api.HealthCheckFailure.Id.ShouldBe(2_002);

    [Fact]
    public void ContainTheExpectedHealthCheckFailureName()
        => AStarEventIds.Api.HealthCheckFailure.Name.ShouldBe("HealthCheck - Failure");

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