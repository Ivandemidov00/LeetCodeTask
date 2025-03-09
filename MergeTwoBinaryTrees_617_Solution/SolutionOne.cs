using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace MergeTwoBinaryTrees_617_Solution;

public class SolutionOne : ISolution<Parameters, TreeNode>
{
    public TreeNode Resolve(Parameters parameters)
    {
        return MergeTrees(parameters.RootOne, parameters.RootTwo);
    }

    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null)
        {
            return null;
        }

        if (root1 == null && root2 != null)
        {
            root1 = new TreeNode(root2.val);
            root1.left = MergeTrees(root1?.left, root2?.left);
            root1.right = MergeTrees(root1?.right, root2?.right);
            return root1;
        }

        if (root1 != null && root2 == null)
        {
            root1.left = MergeTrees(root1?.left, root2?.left);
            root1.right = MergeTrees(root1?.right, root2?.right);
            return root1;
        }

        root1.val += root2.val;
        root1.left = MergeTrees(root1?.left, root2?.left);
        root1.right = MergeTrees(root1?.right, root2?.right);
        return root1;
    }
}