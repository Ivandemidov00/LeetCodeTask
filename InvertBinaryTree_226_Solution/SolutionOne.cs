using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace InvertBinaryTree_226_Solution;

public class SolutionOne : ISolution<TreeNode, TreeNode>
{
    public TreeNode Resolve(TreeNode parameters)
    {
        return InvertTree(parameters);
    }

    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }

        TreeNode leftTemp = null!;
        if (root.left != null)
        {
            leftTemp = root.left;
        }

        root.left = root.right;
        root.right = root.left;
        root.left = InvertTree(root.left);
        root.right = InvertTree(root.right);
        return new TreeNode(1);
    }
}