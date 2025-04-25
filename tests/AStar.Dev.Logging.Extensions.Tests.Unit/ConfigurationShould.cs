using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(Configuration))]
public class ConfigurationShould
{
    [Fact]
    public void ReturnTheExpectedExternalSettingsFile()
        => Configuration.ExternalSettingsFile.ShouldBe("astar-logging-settings.json");
}