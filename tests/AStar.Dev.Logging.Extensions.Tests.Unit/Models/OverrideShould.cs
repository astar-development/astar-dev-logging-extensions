using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions.Models;

[TestSubject(typeof(Override))]
public class OverrideShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new Override().ToJson().ShouldMatchApproved();
}