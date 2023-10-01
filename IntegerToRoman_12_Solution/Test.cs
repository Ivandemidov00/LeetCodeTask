using NUnit.Framework;

using SolutionHelper;

namespace IntegerToRoman_12_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<int, string> _solutionOne = null!;

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public string SolutionOneTest(int num)
        => _solutionOne.Resolve(num);
}