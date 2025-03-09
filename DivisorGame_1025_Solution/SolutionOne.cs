using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace DivisorGame_1025_Solution;

public class SolutionOne : ISolution<int, bool>
{
    public bool Resolve(int parameters)
    {
        return DivisorGame(parameters);
    }

    public bool DivisorGame(int n)
    {
        return (n & 1) == 0;
    }
}