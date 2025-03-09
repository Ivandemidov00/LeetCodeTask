using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace MaximumDifferenceBetweenNodeAndAncetor_1026_Solution;

public class SolutionOne : ISolution<TreeNode, int>
{
    public int Resolve(TreeNode parameters)
    {
        return MaxAncestorDiff(parameters);
    }

    public int MaxAncestorDiff(TreeNode root)
    {
        return Math.Max(MaxMin(root.left, 0, root.val, root.val), MaxMin(root.right, 0, root.val, root.val));
    }

    public int MaxMin(TreeNode? root, int maxDiff, int maxParent, int minParent)
    {
        if (root is null)
        {
            return maxDiff;
        }

        maxDiff = Math.Max(maxDiff, Math.Max(Math.Abs(root.val - maxParent), Math.Abs(root.val - minParent)));
        maxParent = Math.Max(maxParent, root.val);
        minParent = Math.Min(minParent, root.val);

        return (root.left, root.right) switch
        {
            (not null, not null) => Math.Max(maxDiff,
                Math.Max(MaxMin(root.right, maxDiff, maxParent, minParent),
                    MaxMin(root.left, maxDiff, maxParent, minParent))),
            (null, not null) => Math.Max(maxDiff, MaxMin(root.right, maxDiff, maxParent, minParent)),
            (not null, null) => Math.Max(MaxMin(root.left, maxDiff, maxParent, minParent), maxDiff),
            (null, null) => maxDiff
        };
    }
}