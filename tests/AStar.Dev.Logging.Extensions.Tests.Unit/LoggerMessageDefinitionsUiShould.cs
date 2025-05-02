using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(LoggerMessageDefinitionsUi))]
public class LoggerMessageDefinitionsUiShould
{
    [Fact]
    public void DefineThePageViewMessageAsExpected()
    {
        var pageView = LoggerMessageDefinitionsUi.PageView;

        pageView.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)");
        pageView.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass10_0`1[System.String]");
    }
}