using NUnit.Framework;

using SolutionHelper;

namespace JewelsAndStones_771;

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