using System.Collections;

using NUnit.Framework;

using SolutionHelper;

namespace SameTree_100_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(new Parameters(new TreeNode(), new TreeNode())).Returns(true);
            yield return new TestCaseData(new Parameters(new TreeNode(3, new TreeNode(5), new TreeNode(6)),
                new TreeNode(3, new TreeNode(5), new TreeNode(6)))).Returns(true);
            yield return new TestCaseData(new Parameters(new TreeNode(1, new TreeNode(2), new TreeNode(1)),
                new TreeNode(1, new TreeNode(1), new TreeNode(1)))).Returns(false);
        }
    }
}