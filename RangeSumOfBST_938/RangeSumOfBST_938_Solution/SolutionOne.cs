using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace RangeSumOfBST_938_Solution;

public class SolutionOne : ISolution<Parameters, int>
{
    public int Resolve(Parameters parameters)
    {
        return RangeSumBST(parameters.Root, parameters.Low, parameters.High);
    }

    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root == null)
        {
            return 0;
        }

        return root.val switch
        {
            var value when value >= low && value > high => RangeSumBST(root.left, low, high),
            var value when value < low && value <= high => RangeSumBST(root.right, low, high),
            var value => value
                         + RangeSumBST(root.left, low, high)
                         + RangeSumBST(root.right, low, high)
        };
    }
}