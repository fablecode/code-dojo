using FluentAssertions;
using NUnit.Framework;

namespace RomanToNumbers
{
    [TestFixture]
    public class SolutionTests
    {
        private Solution _sut = null!;

        [SetUp]
        public void SetUp()
        {
            _sut = new Solution();
        }

        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("XL", 40)]
        [TestCase("XC", 90)]
        [TestCase("CD", 400)]
        [TestCase("CM", 900)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]
        public void Given_A_Roman_Numeral_Should_Return_Its_Respective_Integer_Number(string roman, int expected)
        {
            // Arrange
            // Act
            var number = _sut.ConvertRomanToInteger(roman);

            // Assert
            number.Should().Be(expected);
        }
    }
}