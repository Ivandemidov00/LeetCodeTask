using NUnit.Framework;

using SolutionHelper;

namespace SameTree_100_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Parameters, bool> _solutionOne = null!;

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public bool SolutionOneTest(Parameters parameters)
        => _solutionOne.Resolve(parameters);
}