using NUnit.Framework;

using SolutionHelper;

namespace FindWordsContainingCharacter_2942_Solution;

public class Test
{
    private ISolution<Parameters, IList<int>> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public IList<int> SolutionOneTest(Parameters command)
    {
        return _solutionOne.Resolve(command);
    }
}