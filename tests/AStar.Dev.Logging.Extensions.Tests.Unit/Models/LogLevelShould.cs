using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions.Models;

[TestSubject(typeof(LogLevel))]
public class LogLevelShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new LogLevel().ToJson().ShouldMatchApproved();
}