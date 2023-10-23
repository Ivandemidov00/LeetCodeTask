using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace RangeSumOfBST_938_Solution;

public class SolutionOne : ISolution<Parameters, int>
{
    public int Resolve(Parameters parameters)
        => RangeSumBST(parameters.Root, parameters.Low, parameters.High);

    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if(root == null)
            return 0;
        if(root.val >= low && root.val <= high)
            return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
        if(root.val < low && root.val <= high)
            return RangeSumBST(root.right, low, high);
        return RangeSumBST(root.left, low, high);
    }
}