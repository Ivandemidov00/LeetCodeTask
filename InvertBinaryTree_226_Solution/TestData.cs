using System.Collections;

using NUnit.Framework;

using SolutionHelper;

namespace InvertBinaryTree_226_Solution;

public class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new TreeNode(1)).Returns(new TreeNode(1));
        }
    }
}