using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions.Models;

[TestSubject(typeof(Serilog))]
public class SerilogShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new Serilog().ToJson().ShouldMatchApproved();
}