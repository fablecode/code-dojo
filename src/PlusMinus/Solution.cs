namespace PlusMinus;

public class Solution
{
    public string[] PlusMinus(int[] collection)
    {
        int positives = 0, negatives = 0, zeros = 0;
        var length = collection.Count();


        for (var i = 0; i < length; i++)
        {
            if (collection[i] > 0)
            {
                positives++;
            }
            else if (collection[i] < 0)
            {
                negatives++;
            }
            else
            {
                zeros++;
            }
        }

        return new[]
        {
            decimal.Divide(positives, length), 
            decimal.Divide(negatives, length), 
            decimal.Divide(zeros, length)
        }
            .Select(d => d.ToString("F6"))
            .ToArray();
    }
}