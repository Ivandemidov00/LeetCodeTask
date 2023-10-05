using NUnit.Framework;

using SolutionHelper;

namespace MinCostClimbingStairs_746_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<int[], int> _solutionOne = null!;
    
    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public int SolutionOneTest(int[] data)
        => _solutionOne.Resolve(data);
}