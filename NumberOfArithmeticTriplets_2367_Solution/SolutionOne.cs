using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBeMadeStatic.Global

namespace NumberOfArithmeticTriplets_2367_Solution;

public class SolutionOne : ISolution<Parameters, int>
{
    public int Resolve(Parameters parameters)
    {
        return ArithmeticTriplets(parameters.Nums, parameters.Diff);
    }

    public int ArithmeticTriplets(int[] nums, int diff)
    {
        int count = 0;
        Queue<int>? numsQueue = new(nums);
        while (numsQueue.TryDequeue(out int num))
        {
            if (numsQueue.Contains(num + diff) &&
                numsQueue.Contains(num + (diff * 2)))
            {
                count++;
            }
        }

        GC.Collect();
        return count;
    }
}