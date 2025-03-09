using NUnit.Framework;

using SolutionHelper;

namespace NumberOfArithmeticTriplets_2367_Solution;

public class Test
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