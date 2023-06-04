using FluentAssertions;
using NUnit.Framework;

namespace DiagonalDifference
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

        //[TestCase(new int[][] { new int[] { 1, 3, 5, 7, 9 }, new int[] { 0, 2, 4, 6 }, new int[] { 11, 22 } })]

        [TestCaseSource(nameof(_testCases))]
        public void Given_Jagged_Array_Of_Integers_Should_Calculate_And_Return_The_Diagonal_Difference_Between_The_Sums_Of_Its_Diagonals(int[][] arr, int expected)
        {
            // Arrange
            // Act
            var result = _sut.DiagonalDifference(arr);

            // Assert
            result.Should().Be(expected);
        }

        private static object[] _testCases =
        {
            new object[]
            {
                new[]
                {
                    new[] { 1, 2, 3 }, 
                    new[] { 4, 5, 6 }, 
                    new[] { 9, 8, 9 }
                },
                2
            }
        };
    }

    public class Solution
    {
        public int DiagonalDifference(int[][] arr)
        {
            var n = arr.Length;
            var d1 = 0;
            var d2 = 0;

            for (var r = 0; r < n; r++)
            {
                for (var c = 0; c < n; c++)
                {
                    // finding the sum of primary diagonal
                    if (r == c)
                    {
                        d1 += arr[r][c];
                    }

                    // finding the sum of secondary diagonal
                    if (r + c == n - 1)
                    {
                        d2 += arr[r][c];
                    }
                }
            }

            return Math.Abs(d1 - d2);
        }
    }
}