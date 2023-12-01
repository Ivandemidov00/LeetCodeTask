using System.Collections;

using NUnit.Framework;

using SolutionHelper;

namespace MergeTwoBinaryTrees_617_Solution;

public static class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new Parameters(new TreeNode(1), new TreeNode(1, right: new TreeNode(2))))
                .Returns(new TreeNode(2, right: new TreeNode(2)));
            yield return new TestCaseData(new Parameters(null, new TreeNode(1)))
                .Returns(new TreeNode(1));
        }
    }
}