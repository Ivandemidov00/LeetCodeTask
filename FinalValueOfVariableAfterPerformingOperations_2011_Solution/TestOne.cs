using NUnit.Framework;

using SolutionHelper;

namespace FinalValueOfVariableAfterPerformingOperations_2011_Solution;

public class TestOne
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Parameters, int> _solutionOne = null!;

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public int SolutionOneTest(Parameters parameters)
        => _solutionOne.Resolve(parameters);
}