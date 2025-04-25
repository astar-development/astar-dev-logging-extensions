using AStar.Dev.Utilities;

namespace AStar.Dev.Logging.Extensions.Models;

public sealed class SerilogConfigShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new SerilogConfig().ToJson().ShouldMatchApproved();
}