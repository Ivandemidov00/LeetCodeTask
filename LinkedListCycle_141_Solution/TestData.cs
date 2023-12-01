using System.Collections;

using NUnit.Framework;

using SolutionHelper;

namespace LinkedListCycle_141_Solution;

public static class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new ListNode()).Returns(false);
        }
    }
}