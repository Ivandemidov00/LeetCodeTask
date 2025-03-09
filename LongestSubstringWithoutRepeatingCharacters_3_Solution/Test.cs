using NUnit.Framework;

using SolutionHelper;

namespace LongestSubstringWithoutRepeatingCharacters_3_Solution;

public class Test
{
    private ISolution<string, int> _solutionOne = null!;
    private ISolution<string, int> _solutionThree = null!;
    private ISolution<string, int> _solutionTwo = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
        _solutionTwo = new SolutionTwo();
        _solutionThree = new SolutionThree();
    }


    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionOneTest(string data)
    {
        return _solutionOne.Resolve(data);
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionTwoTest(string data)
    {
        return _solutionTwo.Resolve(data);
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionThreeTest(string data)
    {
        return _solutionThree.Resolve(data);
    }
}