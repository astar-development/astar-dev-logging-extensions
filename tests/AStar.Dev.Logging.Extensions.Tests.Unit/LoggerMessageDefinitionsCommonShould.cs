using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(LoggerMessageDefinitionsCommon))]
public class LoggerMessageDefinitionsCommonShould
{
    [Fact]
    public void DefineTheCriticalFailureMessageAsExpected()
    {
        var criticalFailure = LoggerMessageDefinitionsCommon.CriticalFailure;

        criticalFailure.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)");
        criticalFailure.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass10_0`1[System.String]");
    }

    [Fact]
    public void DefineTheExceptionOccurredMessageAsExpected()
    {
        var exceptionOccurred = LoggerMessageDefinitionsCommon.ExceptionOccurred;

        exceptionOccurred.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)");
        exceptionOccurred.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass10_0`1[System.String]");
    }
}