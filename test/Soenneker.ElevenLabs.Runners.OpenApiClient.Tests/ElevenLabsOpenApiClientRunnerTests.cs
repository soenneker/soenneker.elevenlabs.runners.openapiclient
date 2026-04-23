using Soenneker.Tests.HostedUnit;

namespace Soenneker.ElevenLabs.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ElevenLabsOpenApiClientRunnerTests : HostedUnitTest
{
    public ElevenLabsOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
