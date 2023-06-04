using FluentAssertions;
using NUnit.Framework;

namespace SolveMeFirst;

[TestFixture]
public class SolutionTests
{
    private Solution _sut = null!;

    [SetUp]
    public void SetUp()
    {
        _sut = new Solution();
    }

    [TestCase(2, 3, 5)]
    public void Given_2_Numbers_Should_Return_The_Sum_Of_Both_Numbers(int a, int b, int expected)
    {
        // Arrange
        // Act
        var result = _sut.SolveMeFirst(a, b);

        // Assert
        result.Should().Be(expected);
    }
}