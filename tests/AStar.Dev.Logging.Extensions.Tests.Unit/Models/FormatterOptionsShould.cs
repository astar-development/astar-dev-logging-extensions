using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions.Models;

[TestSubject(typeof(FormatterOptions))]
public class FormatterOptionsShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new FormatterOptions().ToJson().ShouldMatchApproved();
}