using System.Collections;
using NUnit.Framework;

namespace MergeTwoSortedLists_21_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(new Parameters(new ListNode(1, new ListNode(2, new ListNode(4))), new ListNode(1, new ListNode(3, new ListNode(4))))).Returns(new List<int>{1,1,2,3,4,4});
            yield return new TestCaseData(new Parameters(new ListNode(), new ListNode(0))).Returns(new List<int>{0, 0});
            yield return new TestCaseData(new Parameters(new ListNode(), new ListNode())).Returns(new List<int>(){0, 0});
            yield return new TestCaseData(new Parameters(new ListNode(5), new ListNode(1,new ListNode(2,new ListNode(4))))).Returns(new List<int>(){1,2,4,5});
        }
    }
}