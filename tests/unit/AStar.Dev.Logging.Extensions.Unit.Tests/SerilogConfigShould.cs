using AStar.Dev.Logging.Extensions.Models;
using AStar.Dev.Utilities;

namespace AStar.Dev.Logging.Extensions.Unit.Tests;

public class SerilogConfigShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new SerilogConfig().ToJson().Should().Be("{\"Serilog\":{\"Enrich\":[],\"WriteTo\":[],\"MinimumLevel\":{\"Default\":\"\",\"Override\":{\"MicrosoftAspNetCore\":\"\",\"SystemNetHttp\":\"\",\"AStar\":\"\"}}},\"Logging\":{\"Console\":{\"FormatterName\":\"\",\"FormatterOptions\":{\"SingleLine\":false,\"IncludeScopes\":false,\"TimestampFormat\":\"HH:mm:ss \",\"UseUtcTimestamp\":true,\"JsonWriterOptions\":{\"Indented\":false}}},\"ApplicationInsights\":{\"LogLevel\":{\"Default\":\"\",\"MicrosoftAspNetCore\":\"\",\"AStar\":\"\"}}}}");
}
