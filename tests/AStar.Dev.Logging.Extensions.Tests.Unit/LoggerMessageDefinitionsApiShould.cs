using System.Reflection;
using AStar.Dev.Logging.Extensions;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit.Abstractions;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(LoggerMessageDefinitionsApi))]
public class LoggerMessageDefinitionsApiShould
{
    [Fact]
    public void DefineTheHealthCheckFailureMessageAsExpected()
    {
        var healthCheckFailure = LoggerMessageDefinitionsApi.HealthCheckFailure;

        healthCheckFailure.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.String, System.Exception)");
        healthCheckFailure.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass12_0`2[System.String,System.String]");
    }

    [Fact]
    public void DefineTheHealthCheckStartMessageAsExpected()
    {
        var healthCheckStart = LoggerMessageDefinitionsApi.HealthCheckStart;

        healthCheckStart.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)");
        healthCheckStart.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass10_0`1[System.String]");
    }

    [Fact]
    public void DefineTheHealthCheckSuccessMessageAsExpected()
    {
        var healthCheckSuccess = LoggerMessageDefinitionsApi.HealthCheckSuccess;

        healthCheckSuccess.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)");
        healthCheckSuccess.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass10_0`1[System.String]");
    }

    [Fact]
    public void DefineTheHealthCheckWarningMessageAsExpected()
    {
        var healthCheckWarning = LoggerMessageDefinitionsApi.HealthCheckWarning;

        healthCheckWarning.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.String, System.Exception)");
        healthCheckWarning.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass12_0`2[System.String,System.String]");
    }

    [Fact]
    public void DefineTheApiCallFailureMessageAsExpected()
    {
        var apiCallFailure = LoggerMessageDefinitionsApi.ApiCallFailure;

        apiCallFailure.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.String, System.String, System.Exception)");
        apiCallFailure.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass14_0`3[System.String,System.String,System.String]");
    }

    [Fact]
    public void DefineTheApiCallStartMessageAsExpected()
    {
        var apiCallStart = LoggerMessageDefinitionsApi.ApiCallStart;

        apiCallStart.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.String, System.Exception)");
        apiCallStart.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass12_0`2[System.String,System.String]");
    }

    [Fact]
    public void DefineTheApiCallSuccessMessageAsExpected()
    {
        var apiCallSuccess = LoggerMessageDefinitionsApi.ApiCallSuccess;

        apiCallSuccess.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.String, System.Exception)");
        apiCallSuccess.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass12_0`2[System.String,System.String]");
    }

    [Fact]
    public void DefineTheApiCallWarningMessageAsExpected()
    {
        var apiCallWarning = LoggerMessageDefinitionsApi.ApiCallWarning;

        apiCallWarning.Method.ToString().ShouldBe("Void <Define>b__1(Microsoft.Extensions.Logging.ILogger, System.String, System.String, System.String, System.Exception)");
        apiCallWarning.Target?.ToString().ShouldBe("Microsoft.Extensions.Logging.LoggerMessage+<>c__DisplayClass14_0`3[System.String,System.String,System.String]");
    }
}