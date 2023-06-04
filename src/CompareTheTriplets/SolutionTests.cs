using FluentAssertions;
using NUnit.Framework;

namespace CompareTheTriplets
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

        [TestCase(new[] {5, 6, 7}, new[] {3, 6, 10}, new[] {1, 1})]
        [TestCase(new[] {1, 2, 3}, new[] {3, 2, 1}, new[] {1, 1})]
        [TestCase(new[] {17, 28, 30}, new[] {90, 16, 8}, new[] {2, 1})]
        public void Given_Challenge_Points_For_Alice_And_Bob_Should_Find_Their_Comparison_Points(int[] alice, int[] bob, int[] expected)
        {
            // Arrange
            // Act
            var result = _sut.CompareTriplets(alice, bob);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}