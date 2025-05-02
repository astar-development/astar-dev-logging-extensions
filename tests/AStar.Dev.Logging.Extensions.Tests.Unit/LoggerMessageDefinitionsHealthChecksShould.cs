using JetBrains.Annotations;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(LoggerMessageDefinitionsHealthChecks))]
public class LoggerMessageDefinitionsHealthChecksShould
{
    [Fact]
    public void DefineTheHealthCheckFailureMessageAsExpected()
    {
        var healthCheckFailure = LoggerMessageDefinitionsHealthChecks.HealthCheckFailure;

        healthCheckFailure.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.String, System.Exception)");
        healthCheckFailure.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass12_0`2[System.String,System.String]");
    }

    [Fact]
    public void DefineTheHealthCheckStartMessageAsExpected()
    {
        var healthCheckStart = LoggerMessageDefinitionsHealthChecks.HealthCheckStart;

        healthCheckStart.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)");
        healthCheckStart.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass10_0`1[System.String]");
    }

    [Fact]
    public void DefineTheHealthCheckSuccessMessageAsExpected()
    {
        var healthCheckSuccess = LoggerMessageDefinitionsHealthChecks.HealthCheckSuccess;

        healthCheckSuccess.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)");
        healthCheckSuccess.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass10_0`1[System.String]");
    }

    [Fact]
    public void DefineTheHealthCheckWarningMessageAsExpected()
    {
        var healthCheckWarning = LoggerMessageDefinitionsHealthChecks.HealthCheckWarning;

        healthCheckWarning.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.String, System.Exception)");
        healthCheckWarning.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass12_0`2[System.String,System.String]");
    }
}