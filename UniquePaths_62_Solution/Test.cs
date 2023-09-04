using NUnit.Framework;
using SolutionHelper;

namespace UniquePaths_62_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Parameters, int> _solutionOne = null!;
    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionOneTest(Parameters data)
        => _solutionOne.Resolve(data);                 
}