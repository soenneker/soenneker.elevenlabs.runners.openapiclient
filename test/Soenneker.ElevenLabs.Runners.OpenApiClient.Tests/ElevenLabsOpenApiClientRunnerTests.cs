using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.ElevenLabs.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ElevenLabsOpenApiClientRunnerTests : FixturedUnitTest
{
    public ElevenLabsOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
