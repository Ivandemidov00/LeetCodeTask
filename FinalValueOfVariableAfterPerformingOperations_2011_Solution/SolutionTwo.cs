using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace FinalValueOfVariableAfterPerformingOperations_2011_Solution;

public class SolutionTwo : ISolution<Parameters, int>
{
    public int Resolve(Parameters parameters)
    {
        return FinalValueAfterOperations(parameters.Operations);
    }

    public int FinalValueAfterOperations(string[] operations)
    {
        int sum = 0;
        for (int i = 0; i < operations.Length; i++)
        {
            if (operations[i].StartsWith("+") || operations[i].EndsWith("+"))
            {
                sum++;
                continue;
            }

            sum--;
        }

        return sum;
    }
}