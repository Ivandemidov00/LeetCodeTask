using NUnit.Framework;

using SolutionHelper;

namespace DetermineIfTwoEventsHaveConflict_2446_Solution;

public class Test
{
    private ISolution<Parameters, bool> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }


    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public bool SolutionOneTest(Parameters parameters)
    {
        return _solutionOne.Resolve(parameters);
    }
}