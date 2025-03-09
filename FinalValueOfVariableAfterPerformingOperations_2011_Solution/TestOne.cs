using NUnit.Framework;

using SolutionHelper;

namespace FinalValueOfVariableAfterPerformingOperations_2011_Solution;

public class TestOne
{
    private ISolution<Parameters, int> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionThree();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public int SolutionOneTest(Parameters parameters)
    {
        return _solutionOne.Resolve(parameters);
    }
}