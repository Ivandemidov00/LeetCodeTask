using NUnit.Framework;

using SolutionHelper;

namespace InvertBinaryTree_226_Solution;

public class Test
{
    [OneTimeSetUp] 
    public void OneTimeSetUp()
    { 
        _solutionOne = new SolutionOne();
    }

    private ISolution<TreeNode, TreeNode> _solutionOne = null!;

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public TreeNode SolutionOneTest(TreeNode num)
        => _solutionOne.Resolve(num);
}
