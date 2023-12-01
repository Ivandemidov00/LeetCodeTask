using System.Collections;

using NUnit.Framework;

using SolutionHelper;

namespace RootEqualsSumOfChildren_2236_Solution;

public static class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new TreeNode(10, new TreeNode(4), new TreeNode(6))).Returns(true);
        }
    }
}