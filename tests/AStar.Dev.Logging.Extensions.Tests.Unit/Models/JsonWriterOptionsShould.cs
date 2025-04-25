using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions.Models;

[TestSubject(typeof(JsonWriterOptions))]
public class JsonWriterOptionsShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new JsonWriterOptions().ToJson().ShouldMatchApproved();
}