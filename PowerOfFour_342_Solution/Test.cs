using NUnit.Framework;

using SolutionHelper;

namespace PowerOfFour_342_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<int, bool> _solutionOne = null!;

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public bool SolutionOneTest(int parameters)
        => _solutionOne.Resolve(parameters);
}