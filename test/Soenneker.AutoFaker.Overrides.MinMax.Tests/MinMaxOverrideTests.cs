using Soenneker.Tests.HostedUnit;

namespace Soenneker.AutoFaker.Overrides.MinMax.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class MinMaxOverrideTests : HostedUnitTest
{
    public MinMaxOverrideTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
