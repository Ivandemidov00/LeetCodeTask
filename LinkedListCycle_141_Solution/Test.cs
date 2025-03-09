using NUnit.Framework;

using SolutionHelper;

namespace LinkedListCycle_141_Solution;

public class Test
{
    private ISolution<ListNode, bool> _solution = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solution = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public bool TestSolutionOne(ListNode parameter)
    {
        return _solution.Resolve(parameter);
    }
}