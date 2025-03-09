using NUnit.Framework;

using SolutionHelper;

namespace InvertBinaryTree_226_Solution;

public class Test
{
    private ISolution<TreeNode, TreeNode> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public TreeNode SolutionOneTest(TreeNode num)
    {
        return _solutionOne.Resolve(num);
    }
}