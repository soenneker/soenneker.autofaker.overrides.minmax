using AwesomeAssertions;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.AutoFaker.Overrides.MinMax.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class MinMaxOverrideTests : HostedUnitTest
{
    public MinMaxOverrideTests(Host host) : base(host)
    {
    }

    [Test]
    public void Generates_ordered_bounds()
    {
        var autoFaker = new Soenneker.Utils.AutoBogus.AutoFaker();
        autoFaker.Config.Overrides = [new MinMaxOverride()];

        for (var i = 0; i < 250; i++)
        {
            Dtos.MinMax.MinMax result = autoFaker.Generate<Dtos.MinMax.MinMax>();

            result.Min.Should().BeGreaterThanOrEqualTo(0.2M);
            result.Max.Should().BeLessThanOrEqualTo(30M);
            result.Max.Should().BeGreaterThanOrEqualTo(result.Min);
        }
    }
}
