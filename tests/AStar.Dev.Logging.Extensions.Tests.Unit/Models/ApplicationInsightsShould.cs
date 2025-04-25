using AStar.Dev.Logging.Extensions.Models;
using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions.Models;

[TestSubject(typeof(ApplicationInsights))]
public class ApplicationInsightsShould
{

    [Fact]
    public void ContainTheExpectedProperties()
    => new ApplicationInsights().ToJson().ShouldMatchApproved();
}