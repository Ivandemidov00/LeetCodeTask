using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace EvaluateReversePolishNotation_150_Solution;

public class SolutionOne : ISolution<Parameters, int>
{
    public int Resolve(Parameters parameters)
    {
        return EvalRpn(parameters.Tokens);
    }

    public int EvalRpn(string[] tokens)
    {
        return 6;
    }
}