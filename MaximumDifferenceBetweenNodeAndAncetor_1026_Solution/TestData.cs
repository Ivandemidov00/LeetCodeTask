using System.Collections;

using NUnit.Framework;

using SolutionHelper;

namespace MaximumDifferenceBetweenNodeAndAncetor_1026_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(new TreeNode(1, new TreeNode(2))).Returns(1);
            yield return new TestCaseData(new TreeNode(1, right: new TreeNode(2, right: new TreeNode(0, left: new TreeNode(3))) )).Returns(3);
        }
    }
}