using JetBrains.Annotations;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using NSubstitute;

namespace AStar.Dev.Logging.Extensions;

[TestSubject(typeof(CloudRoleNameTelemetryInitializer))]
public class CloudRoleNameTelemetryInitializerShould
{
    [Fact]
    public void InitializeAsExpected()
    {
        var sut           = new CloudRoleNameTelemetryInitializer("CloudRoleName", "InstrumentationKey");
        var mockTelemetry = Substitute.For<ITelemetry>();
        mockTelemetry.Context.ReturnsForAnyArgs(new TelemetryContext());

        sut.Initialize(mockTelemetry);

        mockTelemetry.Context.Cloud.RoleName.ShouldBe("CloudRoleName");
        mockTelemetry.Context.InstrumentationKey.ShouldBe("InstrumentationKey");
    }
}