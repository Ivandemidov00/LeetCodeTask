using System.Collections;

using MergeTwoSortedLists_21_Solution;

using NUnit.Framework;

using SolutionHelper;

namespace ConvertBinaryNumberInALinkedListToInteger_1290_Solution;

public static class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new ListNode(1, new ListNode(0 , new ListNode(1)))).Returns(5);
            yield return new TestCaseData(new ListNode(1, new ListNode(0 , new ListNode(0, new ListNode(1, new ListNode(0, new ListNode(0, new ListNode(1, new ListNode(1, new ListNode(1,new ListNode(0, new ListNode(0,new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0)))))))))))))))).Returns(18880);
        }
    }
}