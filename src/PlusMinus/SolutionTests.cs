using FluentAssertions;
using NUnit.Framework;

namespace PlusMinus
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

        [TestCase(new[] { -4, 3, -9, 0, 4, 1 }, new[] { "0.500000", "0.333333", "0.166667" })]
        [TestCase(new[] { 1, 2, 3, -1, -2, -3, 0, 0 }, new[] { "0.375000", "0.375000", "0.250000" })]
        public void Given_An_Array_Of_Integers_Should_Calculate_The_Ratio_Of_Its_Elements(int[] input, string[] expected)
        {
            // Arrange
            // Act
            var result = _sut.PlusMinus(input);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}