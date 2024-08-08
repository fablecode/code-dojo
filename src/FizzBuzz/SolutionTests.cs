using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase(1, "1")]
        public void Given_A_Number_If_The_Number_Is_Not_A_Multiple_Of_3_And_5_Should_Return_Number(int number, string expected)
        {
            // Arrange
            // Act
            var result = Solution.FizzBuzz(number);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        [TestCase(3)]
        [TestCase(6)]
        public void Given_A_Number_If_The_Number_Is_A_Multiple_Of_3_Should_Return_Fizz(int number)
        {
            // Arrange
            const string expected = "Fizz";

            // Act
            var result = Solution.FizzBuzz(number);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        [TestCase(5)]
        [TestCase(10)]
        public void Given_A_Number_If_The_Number_Is_A_Multiple_Of_5_Should_Return_Buzz(int number)
        {
            // Arrange
            const string expected = "Buzz";

            // Act
            var result = Solution.FizzBuzz(number);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        [TestCase(15)]
        [TestCase(30)]
        public void Given_A_Number_If_The_Number_Is_A_Multiple_Of_3_And_5_Should_Return_FizzBuzz(int number)
        {
            // Arrange
            const string expected = "FizzBuzz";

            // Act
            var result = Solution.FizzBuzz(number);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}