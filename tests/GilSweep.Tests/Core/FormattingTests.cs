using GilSweep.Core;

namespace GilSweep.Tests.Core;

public sealed class FormattingTests
{
    [Theory]
    [InlineData(0.04, "0%")]
    [InlineData(-0.04, "0%")]
    [InlineData(0, "0%")]
    [InlineData(9.96, "+10%")]
    [InlineData(10, "+10%")]
    [InlineData(-12.4, "−12%")]
    [InlineData(0.5, "+0.5%")]
    public void A_signed_percent_takes_its_sign_from_the_rounded_value(double percent, string expected) =>
        Assert.Equal(expected, Formatting.SignedPercent(percent));
}
