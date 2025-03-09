using System.Collections;

using NUnit.Framework;

using SolutionHelper;

namespace MiddleOfTheLinkedList_876_Solution;

public class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new Parameters(
                    new ListNode(1,
                        new ListNode(2,
                            new ListNode(3,
                                new ListNode(4,
                                    new ListNode(5)))))))
                .Returns(new List<int> { 3, 4, 5 });
            yield return new TestCaseData(new Parameters(
                    new ListNode(1,
                        new ListNode(2,
                            new ListNode(3,
                                new ListNode(4,
                                    new ListNode(5,
                                        new ListNode(6))))))))
                .Returns(new List<int> { 4, 5, 6 });
            yield return new TestCaseData(new Parameters(
                    new ListNode(1,
                        new ListNode(2))))
                .Returns(new List<int> { 2 });
        }
    }
}