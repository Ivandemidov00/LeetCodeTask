using NUnit.Framework;
using SolutionHelper;

namespace LongestSubstringWithoutRepeatingCharacters_3_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
        _solutionTwo = new SolutionTwo();
        _solutionThree = new SolutionThree();

    }

    private ISolution<string, int> _solutionOne = null!;
    private ISolution<string, int> _solutionTwo = null!;
    private ISolution<string, int> _solutionThree = null!;


    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionOneTest(string data)
        => _solutionOne.Resolve(data);
    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionTwoTest(string data)
        => _solutionTwo.Resolve(data);
    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionThreeTest(string data)
        => _solutionThree.Resolve(data);

}