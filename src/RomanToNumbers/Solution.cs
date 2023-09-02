namespace RomanToNumbers;

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