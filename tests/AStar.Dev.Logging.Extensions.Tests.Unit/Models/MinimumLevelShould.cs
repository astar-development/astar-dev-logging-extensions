using AStar.Dev.Logging.Extensions.Models;
using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions.Models;

[TestSubject(typeof(MinimumLevel))]
public class MinimumLevelShould
{

    [Fact]
    public void ContainTheExpectedProperties()
    => new MinimumLevel().ToJson().ShouldMatchApproved();
}