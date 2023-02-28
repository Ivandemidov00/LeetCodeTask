using NUnit.Framework;
using SolutionHelper;

namespace DetermineIfTwoEventsHaveConflict_2446_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Parameters, bool> _solutionOne = null!;

    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public bool SolutionOneTest(Parameters parameters) 
        => _solutionOne.Resolve(parameters);
}