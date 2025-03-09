using NUnit.Framework;

using SolutionHelper;

namespace MiddleOfTheLinkedList_876_Solution;

public class Test
{
    private ISolution<Parameters, ListNode> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public List<int> SolutionOneTest(Parameters parameters)
    {
        return _solutionOne.Resolve(parameters).ToList();
    }
}