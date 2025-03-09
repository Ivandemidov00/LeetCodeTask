using NUnit.Framework;

using SolutionHelper;

namespace MinCostClimbingStairs_746_Solution;

public class Test
{
    private ISolution<int[], int> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public int SolutionOneTest(int[] data)
    {
        return _solutionOne.Resolve(data);
    }
}