using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace RootEqualsSumOfChildren_2236_Solution;

public class SolutionOne : ISolution<TreeNode, bool>
{
    public bool Resolve(TreeNode parameters)
    {
        return CheckTree(parameters);
    }

    public bool CheckTree(TreeNode root)
    {
        return root.val == root.left?.val + root.right?.val;
    }
}