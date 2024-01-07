using System.Numerics;

using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace PowerOfFour_342_Solution;

public class SolutionOne : ISolution<int, bool>
{
    public bool Resolve(int parameters)
        => IsPowerOfFour(parameters);
    
    public bool IsPowerOfFour(int n)
    {
        if (n == 1)
            return true;

        var sum = 4;

        while (sum <= n)
        {
            if (sum == n)
            {
                return true;
            }
            sum *= 4;
        }

        return false;
    }
}