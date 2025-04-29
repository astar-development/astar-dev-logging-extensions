using JetBrains.Annotations;
using Microsoft.ApplicationInsights;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(AStarLogger<>))]
public class AStarLoggerShould
{
    private readonly LoggerMessageDefinitions       loggerMessageDefinitions;
    private readonly ILogger<AStarLoggerShould>     mockLogger;
    private readonly IAStarTelemetryClient          mockTelemetryClient;
    private readonly AStarLogger<AStarLoggerShould> sut;

    public AStarLoggerShould()
    {
        mockTelemetryClient = Substitute.For<IAStarTelemetryClient>();
        mockLogger          = Substitute.For<ILoggerAstar<AStarLoggerShould>>();
#pragma warning disable CS0618 // Type or member is obsolete
        mockTelemetryClient.TelemetryClient.ReturnsForAnyArgs(new TelemetryClient());
#pragma warning restore CS0618 // Type or member is obsolete
        loggerMessageDefinitions = Substitute.For<LoggerMessageDefinitions>();
        sut                      = new (loggerMessageDefinitions, mockLogger, mockTelemetryClient);
    }

    [Fact]
    public void ImplementTheILoggerAstarInterface()
        => sut.ShouldBeAssignableTo<ILoggerAstar<AStarLoggerShould>>();

    [Fact]
    public void LogPageViewAsExpected()
    {
        sut.LogPageView("PageNameIsNotRelevant");

        mockTelemetryClient.Received().TrackPageView("PageNameIsNotRelevant");
    }

    [Fact]
    public void DelegateBeginScope()
    {
        const string mockState = "MockState";

        sut.BeginScope(mockState);

        mockLogger.Received().BeginScope(mockState);
    }

    [Fact]
    public void DelegateIsEnabled()
    {
        sut.IsEnabled(LogLevel.Trace);

        mockLogger.Received().IsEnabled(LogLevel.Trace);
    }

    [Fact]
    public void DelegateTheCallToLog()
    {
#pragma warning disable CA1848
        sut.Log(LogLevel.Trace, "Test");

        mockLogger.Received().Log(LogLevel.Trace, "Test");
#pragma warning restore CA1848
    }

    [Fact]
    public void DelegateTheLogHealthCheckStartToTheLoggerMessageDefinitions()
    {
        sut.LogHealthCheckStart("MockApiName");

        loggerMessageDefinitions.Received(1).HealthCheckStart(mockLogger, "MockApiName", null);
    }

    [Fact]
    public void DelegateTheLogHealthCheckSuccessToTheLoggerMessageDefinitions()
    {
        sut.LogHealthCheckSuccess("MockApiName");

        loggerMessageDefinitions.Received(1).HealthCheckSuccess(mockLogger, "MockApiName", null);
    }

    [Fact]
    public void DelegateTheLogHealthCheckWarningToTheLoggerMessageDefinitions()
    {
        sut.LogHealthCheckWarning("MockApiName", "MockWarningMessage");

        loggerMessageDefinitions.Received(1).HealthCheckWarning(mockLogger, "MockApiName", "MockWarningMessage", null);
    }

    [Fact]
    public void DelegateTheLogHealthCheckFailureToTheLoggerMessageDefinitions()
    {
        sut.LogHealthCheckFailure("MockApiName", "MockFailureMessage");

        loggerMessageDefinitions.Received(1).HealthCheckFailure(mockLogger, "MockApiName", "MockFailureMessage", null);
    }

    [Fact]
    public void DelegateTheLogExceptionToTheLoggerMessageDefinitions()
    {
        sut.LogException(new ArgumentException("MockExceptionMessage"));

        loggerMessageDefinitions.Received(1).ExceptionLogMessage(mockLogger, "MockApiName", null);
    }

    [Fact]
    public void DelegateTheLogCriticalFailureToTheLoggerMessageDefinitions()
    {
        sut.LogCriticalFailure(new ArgumentException("MockCriticalMessage"));

        loggerMessageDefinitions.Received(1).CriticalFailure(mockLogger, "MockApiName", null);
    }
}