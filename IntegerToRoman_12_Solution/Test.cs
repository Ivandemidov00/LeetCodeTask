using NUnit.Framework;

using SolutionHelper;

namespace IntegerToRoman_12_Solution;

public class Test
{
    private ISolution<int, string> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public string SolutionOneTest(int num)
    {
        return _solutionOne.Resolve(num);
    }
}