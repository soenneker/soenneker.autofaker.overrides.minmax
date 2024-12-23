using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.AutoFaker.Overrides.MinMax.Tests;

[Collection("Collection")]
public class MinMaxOverrideTests : FixturedUnitTest
{
    public MinMaxOverrideTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
