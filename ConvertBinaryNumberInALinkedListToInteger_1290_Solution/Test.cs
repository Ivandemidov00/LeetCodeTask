using NUnit.Framework;

using SolutionHelper;

namespace ConvertBinaryNumberInALinkedListToInteger_1290_Solution;

public class Test
{
    private ISolution<ListNode, int> _solutionOne = null!;

    [OneTimeSetUp]
    public void OnTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public int SolutionOneTest(ListNode listNode)
    {
        return _solutionOne.Resolve(listNode);
    }
}