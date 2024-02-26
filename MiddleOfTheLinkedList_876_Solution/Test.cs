using NUnit.Framework;

using SolutionHelper;

namespace MiddleOfTheLinkedList_876_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Parameters, ListNode> _solutionOne = null!;

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public List<int> SolutionOneTest(Parameters parameters)
        => _solutionOne.Resolve(parameters).ToList();
}