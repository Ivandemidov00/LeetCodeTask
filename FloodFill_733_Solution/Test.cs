using NUnit.Framework;
using SolutionHelper;

namespace FloodFill_733_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Parameter, int[][]> _solutionOne = null!;
    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int[][] SolutionOneTest(Parameter command) 
        => _solutionOne.Resolve(command);
}
