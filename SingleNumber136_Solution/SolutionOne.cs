using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace SingleNumber136_Solution;

public class SolutionOne : ISolution<int[], int>
{
    public int Resolve(int[] parameters)
    {
        return SingleNumber(parameters);
    }

    public int SingleNumber(int[] nums)
    {
        HashSet<int>? singleNums = new();
        foreach (int num in nums)
        {
            if (singleNums.Contains(num))
            {
                singleNums.Remove(num);
            }
            else
            {
                singleNums.Add(num);
            }
        }

        return singleNums.First();
    }
}