using NUnit.Framework;

using SolutionHelper;

namespace PascalTriangle_118_Solution;

public class Test
{
    private ISolution<int, IList<IList<int>>> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public IList<IList<int>> SolutionOneTest(int data)
    {
        return _solutionOne.Resolve(data);
    }
}