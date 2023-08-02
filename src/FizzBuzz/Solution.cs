namespace FizzBuzz;

public class Solution
{
    public static string FizzBuzz(int number)
    {
        if (IsMultipleOfThree(number) && IsMultipleOfFive(number))
        {
            return "FizzBuzz";
        }

        if (IsMultipleOfThree(number))
        {
            return "Fizz";
        }

        if (IsMultipleOfFive(number))
        {
            return "Buzz";
        }

        return number.ToString();
    }

    private static bool IsMultipleOfThree(int number)
    {
        return (number % 3) == 0;
    }
    private static bool IsMultipleOfFive(int number)
    {
        return (number % 5) == 0;
    }
}