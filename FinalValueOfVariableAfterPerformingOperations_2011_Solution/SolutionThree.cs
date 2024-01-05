using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace FinalValueOfVariableAfterPerformingOperations_2011_Solution;

public class SolutionThree : ISolution<Parameters, int>
{
    public int Resolve(Parameters parameters)
        => FinalValueAfterOperations(parameters.Operations);

    public int FinalValueAfterOperations(string[] operations)
    {
        var sum = 0;
        const int ascii = 44;
        foreach (var operation in operations)
        {
            sum += (ascii - operation[1]);
        }

        return sum;
    }
}