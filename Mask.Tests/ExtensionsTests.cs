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
        [InlineData("1234", "1234", "")]
        [InlineData("1234", "1234", " ")]
        [InlineData("1234", "1234", null)]
        public void Should_Make_Mask(string value, string expected, string mask)
        {
            Assert.Equal(expected, value.ToMasked(mask));
        }

        [Fact]
        public void Should_Make_Mask_For_Cellphone()
        {
            Assert.Equal("(11) 98564-4568", "11985644568".ToMasked("(AA) AAAAA-AAAA"));
        }
    }
}
