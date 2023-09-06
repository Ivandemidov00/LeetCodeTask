using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace CountingBits_338_Solution;

public class SolutionOne : ISolution<int, int[]>
{
    public int[] Resolve(int parameter)
        => CountBits(parameter);
    
    public int[] CountBits(int n)
    {
        var result = new int[n+1];
        result[0] = 0;
        foreach (var i in Enumerable.Range(1, n))
        {
            result[i] = result[i >> 1] + (i & 1);
        }

        return result;
    }
}