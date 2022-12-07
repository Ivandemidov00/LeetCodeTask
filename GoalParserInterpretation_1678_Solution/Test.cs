using NUnit.Framework;
using SolutionHelper;

namespace GoalParserInterpretation_1678_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
        _solutionTwo = new SolutionTwo();
    }

    private ISolution<string, string> _solutionOne = null!;
    private ISolution<string, string> _solutionTwo = null!;

    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public string SolutionOneTest(string command) 
        => _solutionOne.Resolve(command);
    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public string SolutionTwoTest(string command) 
        => _solutionTwo.Resolve(command);
    
}