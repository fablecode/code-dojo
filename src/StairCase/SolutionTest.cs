using FluentAssertions;
using NUnit.Framework;

namespace StairCase;

public class SolutionTest
{
    [TestCase(4, "   #\r\n  ##\r\n ###\r\n####\r\n")]
    public void Given_A_Size_Should_Invoke_Staircase1_Method_And_Print_A_Staircase_Of_That_Size(int size, string expected)
    {
        // Arrange
        // Act
        var result = Solution.Staircase1(size);

        // Assert
        result.Should().Be(expected);
    }

    [TestCase(4, "   #\r\n  ##\r\n ###\r\n####\r\n")]
    public void Given_A_Size_Should_Invoke_Staircase2_Method_And_Print_A_Staircase_Of_That_Size(int size, string expected)
    {
        // Arrange
        // Act
        var result = Solution.Staircase2(size);

        // Assert
        result.Should().Be(expected);
    }
}