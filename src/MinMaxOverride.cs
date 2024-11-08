using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;

namespace Soenneker.AutoFaker.Overrides.MinMax;

/// <summary>
/// An AutoFaker (AutoBogus) override for the DTO MinMax
/// </summary>
public class MinMaxOverride : AutoFakerOverride<Dtos.MinMax.MinMax>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Dtos.MinMax.MinMax)!;

        target.Max = context.Faker.Finance.Amount(0.2M, 30);
        target.Min = context.Faker.Finance.Amount(0.2M, target.Max * .95M);
    }
}