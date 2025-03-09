using NUnit.Framework;

using SolutionHelper;

namespace FloodFill_733_Solution;

public class Test
{
    private ISolution<Parameter, int[][]> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int[][] SolutionOneTest(Parameter command)
    {
        return _solutionOne.Resolve(command);
    }
}