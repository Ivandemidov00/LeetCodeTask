using NUnit.Framework;

using SolutionHelper;

namespace LongestIncreasingSubsequence_300_Solution;

public class TestOne
{
    private ISolution<Parameters, int> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public int SolutionOneTest(Parameters parameters)
    {
        return _solutionOne.Resolve(parameters);
    }
}