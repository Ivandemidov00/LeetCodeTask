using NUnit.Framework;

using SolutionHelper;

namespace FindWordsContainingCharacter_2942_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Parameters, IList<int>> _solutionOne = null!;
    
    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public IList<int> SolutionOneTest(Parameters command) 
        => _solutionOne.Resolve(command);
}