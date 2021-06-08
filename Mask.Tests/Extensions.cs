using Xunit;

namespace Mask.Tests
{
    public class Extensions
    {
        [Theory]
        [InlineData("12356978945", "123.569.789-45", "000.000.000-00")]
        [InlineData("12356978945", "123.569.789-45", "SSS.SSS.SSS-SS")]
        [InlineData("12356978945", "123.569.789-45", "AAA.AAA.AAA-AA")]
        [InlineData("12356978945", "123.569.789-45", "999.999.999-99")]
        [InlineData("1234567890", "1234 5678-90", "AAAA 0000-SS")]
        [InlineData("1234", "OOOO", "OOOO")]
        public void Should_Make_Mask(string value, string expected, string mask)
        {
            Assert.Equal(expected, value.ToMasked(mask));
        }
    }
}
