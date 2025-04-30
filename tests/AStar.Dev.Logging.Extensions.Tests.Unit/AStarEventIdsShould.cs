using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(AStarEventIds.Ui))]
public class AStarEventIdsUiShould
{
    [Fact]
    public void ContainTheExpectedPageViewEventId()
        => AStarEventIds.Ui.PageView.Id.ShouldBe(1_000);

    [Fact]
    public void ContainTheExpectedPageViewName()
        => AStarEventIds.Ui.PageView.Name.ShouldBe("Page View");
}