using FluentAssertions;
using NUnit.Framework;

namespace SimpleArraySum
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

        [TestCase(new[] { 6 }, 6)]
        [TestCase(new[] { 1, 2, 3, 4, 10, 11 }, 31)]
        public void Given_An_Array_Of_Integers_Should_Return_The_Sum_Of_The_Array_Elements_As_An_Integer(int[] ar, int expected)
        {
            // Arrange
            // Act
            var result = _sut.SimpleArraySum(ar);

            // Assert
            result.Should().Be(expected);
        }
    }
}