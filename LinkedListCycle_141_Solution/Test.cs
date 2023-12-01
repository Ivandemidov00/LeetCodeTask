using NUnit.Framework;

using SolutionHelper;

namespace LinkedListCycle_141_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solution = new SolutionOne();
    }

    private ISolution<ListNode, bool> _solution = null!;

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public bool TestSolutionOne(ListNode parameter)
        => _solution.Resolve(parameter);
}