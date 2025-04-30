using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(AStarEventIds.Api))]
public class AStarEventIdsApiShould
{
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
        => AStarEventIds.Api.HealthCheckFailure.Id.ShouldBe(2_003);

    [Fact]
    public void ContainTheExpectedHealthCheckFailureName()
        => AStarEventIds.Api.HealthCheckFailure.Name.ShouldBe("HealthCheck - Failure");

    [Fact]
    public void ContainTheExpectedApiCallStartEventId()
        => AStarEventIds.Api.ApiCallStart.Id.ShouldBe(2_004);

    [Fact]
    public void ContainTheExpectedApiCallStartName()
        => AStarEventIds.Api.ApiCallStart.Name.ShouldBe("ApiCall - Start");

    [Fact]
    public void ContainTheExpectedApiCallSuccessEventId()
        => AStarEventIds.Api.ApiCallSuccess.Id.ShouldBe(2_005);

    [Fact]
    public void ContainTheExpectedApiCallSuccessName()
        => AStarEventIds.Api.ApiCallSuccess.Name.ShouldBe("ApiCall - Success");

    [Fact]
    public void ContainTheExpectedApiCallWarningEventId()
        => AStarEventIds.Api.ApiCallWarning.Id.ShouldBe(2_006);

    [Fact]
    public void ContainTheExpectedApiCallWarningName()
        => AStarEventIds.Api.ApiCallWarning.Name.ShouldBe("ApiCall - Warning");

    [Fact]
    public void ContainTheExpectedApiCallFailureEventId()
        => AStarEventIds.Api.ApiCallFailure.Id.ShouldBe(2_007);

    [Fact]
    public void ContainTheExpectedApiCallFailureName()
        => AStarEventIds.Api.ApiCallFailure.Name.ShouldBe("ApiCall - Failure");
}