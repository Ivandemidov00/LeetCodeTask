using NUnit.Framework;

using SolutionHelper;

namespace SingleNumber136_Solution;

public class Test
{
    private ISolution<int[], int> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionOneTest(int[] data)
    {
        return _solutionOne.Resolve(data);
    }
}