using System.Collections;

using NUnit.Framework;

using SolutionHelper;

namespace RangeSumOfBST_938_Solution;

public static class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(new Parameters(
                new TreeNode(10, new TreeNode(5, new TreeNode(3), new TreeNode(7)),
                    new TreeNode(15, right: new TreeNode(18))), 7, 15)).Returns(32);
        }
    }
}