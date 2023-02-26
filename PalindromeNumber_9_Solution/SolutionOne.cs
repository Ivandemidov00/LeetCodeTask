using SolutionHelper;

namespace PalindromeNumber_9_Solution;

public class SolutionOne : ISolution<int, bool>
{
    public bool Resolve(int parameter)
        => IsPalindrome(parameter);
    
    public bool IsPalindrome(int x)
    {
        var xString = Convert.ToString(x);
        var i = 0;
        while (i < xString.Length / 2)
        {
            if (xString[i] != xString[^++i])
                return false;
        }
        return true;
    }
}