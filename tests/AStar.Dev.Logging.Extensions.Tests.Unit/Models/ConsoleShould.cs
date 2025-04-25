using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions.Models;

[TestSubject(typeof(Console))]
public class ConsoleShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new Console().ToJson().ShouldMatchApproved();
}