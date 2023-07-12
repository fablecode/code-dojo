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

    public class Solution
    {
        private Dictionary<char, int> _romanNumeralMapping = new()
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        public int ConvertRomanToInteger(string roman)
        {
            var sum = 0;

            for (var i = 0; i < roman.Length; i++)
            {
                var currentRomanChar = roman[i];
                if (_romanNumeralMapping.TryGetValue(currentRomanChar, out var num))
                {
                    if (DoesNextRomanExist(roman, i) && IsNextRomanGreaterThanCurrent(roman, i, currentRomanChar))
                    {
                        sum -= num;
                    }
                    else
                    {
                        sum += num;
                    }
                }
            }

            return sum;
        }

        private bool IsNextRomanGreaterThanCurrent(string roman, int i, char currentRomanChar)
        {
            return _romanNumeralMapping[roman[i + 1]] > _romanNumeralMapping[currentRomanChar];
        }

        private static bool DoesNextRomanExist(string roman, int i)
        {
            return i + 1 < roman.Length;
        }
    }
}