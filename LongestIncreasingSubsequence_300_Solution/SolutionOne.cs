using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace LongestIncreasingSubsequence_300_Solution;

public class SolutionOne : ISolution<Parameters, int>
{
    public int Resolve(Parameters parameters)
    {
        return LengthOfLIS(parameters.Nums);
    }

    public int LengthOfLIS(int[] nums)
    {
        int maxLIS = 0;
        int lengthCurrentSubSequence = 1;
        int minNumberInSubSequence = nums[0];
        int maxNumberInCurrentSubSequence = nums[0];
        foreach (int num in nums)
        {
            if (num > minNumberInSubSequence)
            {
                if (num > maxNumberInCurrentSubSequence)
                {
                    lengthCurrentSubSequence++;
                }
            }
            else
            {
                maxLIS = lengthCurrentSubSequence;
                lengthCurrentSubSequence = 0;
            }
        }

        return maxLIS;
    }
}