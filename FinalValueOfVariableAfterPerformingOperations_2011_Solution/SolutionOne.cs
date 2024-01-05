using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace FinalValueOfVariableAfterPerformingOperations_2011_Solution;

public class SolutionOne : ISolution<Parameters, int>
{
    public int Resolve(Parameters parameters)
        => FinalValueAfterOperations(parameters.Operations);

    public int FinalValueAfterOperations(string[] operations)
    {
        var sum = 0;
        foreach (var operation in operations)
        {
            var operationValue = operation switch
            {
                "--X" => -1,
                "X--" => -1,
                "++X" => 1,
                "X++" => 1,
                _ => 0
            };
            sum += operationValue;
        }
        return sum;
    }
}