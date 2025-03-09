using NUnit.Framework;

using SolutionHelper;

namespace PowerOfFour_342_Solution;

public class Test
{
    private ISolution<int, bool> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public bool SolutionOneTest(int parameters)
    {
        return _solutionOne.Resolve(parameters);
    }
}