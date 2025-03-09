using NUnit.Framework;

using SolutionHelper;

namespace DivisorGame_1025_Solution;

public class Test
{
    private ISolution<int, bool> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public bool SolutionOneTest(int num)
    {
        return _solutionOne.Resolve(num);
    }
}