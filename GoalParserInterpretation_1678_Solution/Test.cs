using NUnit.Framework;

using SolutionHelper;

namespace GoalParserInterpretation_1678_Solution;

public class Test
{
    private ISolution<string, string> _solutionOne = null!;
    private ISolution<string, string> _solutionTwo = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
        _solutionTwo = new SolutionTwo();
    }


    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public string SolutionOneTest(string command)
    {
        return _solutionOne.Resolve(command);
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public string SolutionTwoTest(string command)
    {
        return _solutionTwo.Resolve(command);
    }
}