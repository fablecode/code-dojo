using System.Text;

namespace StairCase
{
    public class Solution
    {
        public static string Staircase1(int size)
        {
            var staircase = new StringBuilder();

            for (var i = 1; i <= size; i++)
            {
                // Print the leading spaces
                for (var j = 1; j <= size - i; j++)
                {
                    staircase.Append(" ");
                }

                // Print the '#' symbols
                for (var k = 1; k <= i; k++)
                {
                    staircase.Append("#");
                }

                // Append a newline character to move to the next line
                staircase.AppendLine();
            }

            return staircase.ToString();
        }

        // Using the StringBuilder Append function overloads
        public static string Staircase2(int size)
        {
            var staircase = new StringBuilder();

            for (var i = 1; i <= size; i++)
            {
                // Print the leading spaces
                staircase.Append(' ', size - i);

                // Print the '#' symbols
                staircase.Append('#', i);

                // Append a newline character to move to the next line
                staircase.AppendLine();
            }

            return staircase.ToString();
        }
    }
}
