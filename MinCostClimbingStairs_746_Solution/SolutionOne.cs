using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace MinCostClimbingStairs_746_Solution;

public class SolutionOne : ISolution<int[], int>
{
    public int Resolve(int[] parameter)
        => MinCostClimbingStairs(parameter);

    public int MinCostClimbingStairs(int[] cost)
        => Math.Min(GoToStairs(cost.Length - 1, cost), GoToStairs(cost.Length - 2, cost));

    private static int GoToStairs(int i, int[] cost)
        => i switch
        {
            < 0 => 0,
            0 or 1 => cost[i],
            _ => cost[i] + Math.Min(GoToStairs(i - 1, cost), GoToStairs(i - 2, cost))
        };
}