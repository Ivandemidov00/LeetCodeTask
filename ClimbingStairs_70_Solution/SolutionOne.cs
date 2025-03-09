using SolutionHelper;

namespace ClimbingStairs_70_Solution;

public class SolutionOne : ISolution<int, int>
{
    public int Resolve(int parameters)
    {
        return ClimbStairs(parameters);
    }

    public int ClimbStairs(int n)
    {
        if (n < 3)
        {
            return n;
        }

        int tempFirst = 1;
        int tempSecond = 2;

        for (byte i = 2; i < n; i++)
        {
            tempSecond += tempFirst;
            tempFirst = tempSecond - tempFirst;
        }

        return tempSecond;
    }
}