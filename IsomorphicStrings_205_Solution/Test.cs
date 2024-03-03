using NUnit.Framework;

using SolutionHelper;

namespace IsomorphicStrings_205_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Parameters, bool> _solutionOne = null!;

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public bool SolutionOneTest(Parameters parameters)
        => _solutionOne.Resolve(parameters);
}