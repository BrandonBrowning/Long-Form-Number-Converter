using Common;
using Xunit;

namespace Unit_Tests
{
    public class NumberFormatterFacts
    {
        [Theory]
        [InlineData(0, "Zero")]
        [InlineData(1, "One")]
        [InlineData(7, "Seven")]
        [InlineData(12, "Twelve")]
        [InlineData(20, "Twenty")]
        [InlineData(25, "Twenty Five")]
        [InlineData(99, "Ninety Nine")]
        [InlineData(100, "One Hundred")]
        [InlineData(888, "Eight Hundred Eighty Eight")]
        [InlineData(1234, "One Thousand, Two Hundred Thirty Four")]
        [InlineData(777_000, "Seven Hundred Seventy Seven Thousand")]
        [InlineData(1_000_000_003, "One Billion Three")]
        [InlineData(2_147_483_647, "Two Billion, One Hundred Fourty Seven Million, Four Hundred Eighty Three Thousand, Six Hundred Fourty Seven")]
        public void Spell(int input, string expected)
        {
            string actual = NumberFormatter.Spell(input.ToString());

            Assert.Equal(expected, actual);
        }
    }
}
