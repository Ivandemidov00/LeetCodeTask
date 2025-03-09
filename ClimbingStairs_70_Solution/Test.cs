using NUnit.Framework;

using SolutionHelper;

namespace ClimbingStairs_70_Solution;

public class Test
{
    private ISolution<int, int> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionOneTest(int command)
    {
        return _solutionOne.Resolve(command);
    }
}