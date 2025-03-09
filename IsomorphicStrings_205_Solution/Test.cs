using NUnit.Framework;

using SolutionHelper;

namespace IsomorphicStrings_205_Solution;

public class Test
{
    private ISolution<Parameters, bool> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public bool SolutionOneTest(Parameters parameters)
    {
        return _solutionOne.Resolve(parameters);
    }
}