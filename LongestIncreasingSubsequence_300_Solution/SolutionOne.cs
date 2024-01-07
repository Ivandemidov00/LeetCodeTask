using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace LongestIncreasingSubsequence_300_Solution;

public class SolutionOne : ISolution<Parameters, int>
{
    public int Resolve(Parameters parameters)
        => LengthOfLIS(parameters.Nums);

    public int LengthOfLIS(int[] nums)
    {
        var maxLIS = 0;
        var lengthCurrentSubSequence = 1;
        var minNumberInSubSequence = nums[0];
        var maxNumberInCurrentSubSequence = nums[0];
        foreach (var num in nums)
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