namespace CompareTheTriplets;

public class Solution
{
    public int[] CompareTriplets(int[] alice, int[] bob)
    {
        var aliceScore = 0;
        var bobScore = 0;

        for (var i = 0; i < alice.Length; i++)
        {
            var aliceRating = alice[i];
            var bobRating = bob[i];

            if (aliceRating > bobRating)
            {
                aliceScore++;
            }
            else if(aliceRating < bobRating)
            {
                bobScore++;
            }
        }

        return new[] { aliceScore, bobScore };
    }
}