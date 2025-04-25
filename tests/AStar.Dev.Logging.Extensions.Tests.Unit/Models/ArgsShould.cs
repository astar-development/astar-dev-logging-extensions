using AStar.Dev.Logging.Extensions.Models;
using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions.Models;

[TestSubject(typeof(Args))]
public class ArgsShould
{

    [Fact]
    public void ContainTheExpectedProperties()
    => new Args().ToJson().ShouldMatchApproved();
}