using NUnit.Framework;

using SolutionHelper;

namespace DivisorGame_1025_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<int, bool> _solutionOne = null!;

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public bool SolutionOneTest(int num)
        => _solutionOne.Resolve(num);
}