using AStar.Dev.Logging.Extensions;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(AStarEventIds))]
public class AStarEventIdsShould
{
    [Fact]
    public void ContainTheExpectedPageViewEventId()
        => AStarEventIds.PageView.Id.ShouldBe(1_000);

    [Fact]
    public void ContainTheExpectedPageViewName()
        => AStarEventIds.PageView.Name.ShouldBe("Page view");
}