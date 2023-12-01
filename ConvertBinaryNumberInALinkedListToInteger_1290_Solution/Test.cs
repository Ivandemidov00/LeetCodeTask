using NUnit.Framework;

using SolutionHelper;

namespace ConvertBinaryNumberInALinkedListToInteger_1290_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OnTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<ListNode, int> _solutionOne = null!;

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public int SolutionOneTest(ListNode listNode)
        => _solutionOne.Resolve(listNode);
}