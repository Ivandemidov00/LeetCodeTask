using SolutionHelper;

namespace ClimbingStairs_70_Solution;

public class SolutionOne : ISolution<int, int>
{
    public int Resolve(int parameter)
        => ClimbStairs(parameter);

    public int ClimbStairs(int n)
    {
        if (n <= 2)
            return n;
        
        var tempFirst = 1;
        var tempSecond = 2;

        for (byte i = 2; i < n; i++)
        {
            tempSecond += tempFirst;
            tempFirst = tempSecond - tempFirst;
        }
            
        return tempSecond;
    }
}