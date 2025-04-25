using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions.Models;

[TestSubject(typeof(WriteTo))]
public class WriteToShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new WriteTo().ToJson().ShouldMatchApproved();
}