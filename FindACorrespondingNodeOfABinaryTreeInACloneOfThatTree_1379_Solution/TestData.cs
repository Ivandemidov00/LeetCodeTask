using System.Collections;
using System.Reflection.Metadata;

using NUnit.Framework;

using SolutionHelper;

namespace FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree_1379_Solution;

public static class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new Parameters(new TreeNode(7, new TreeNode(4), new TreeNode(3, new TreeNode(6), new TreeNode(10))),
                new TreeNode(7, new TreeNode(4), new TreeNode(3, new TreeNode(6), new TreeNode(10))),
                new TreeNode(3)))
                .Returns(new TreeNode(3));
        }
    }
}