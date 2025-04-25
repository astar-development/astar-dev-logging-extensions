using AStar.Dev.Logging.Extensions.Models;
using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions.Models;

[TestSubject(typeof(Logging))]
public class LoggingShould
{

    [Fact]
    public void ContainTheExpectedProperties()
    => new Logging().ToJson().ShouldMatchApproved();
}