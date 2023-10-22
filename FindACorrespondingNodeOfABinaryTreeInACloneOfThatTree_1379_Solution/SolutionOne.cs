using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree_1379_Solution;

public class SolutionOne : ISolution<Parameters, TreeNode>
{
    public TreeNode Resolve(Parameters parameters)
        => GetTargetCopy(parameters.Original, parameters.Cloned, parameters.Target);

    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        => original switch
        {
            null => null,
            not null when original.val == target.val => cloned,
            not null when original.left == null => GetTargetCopy(original?.right, cloned?.right, target),
            not null when original.right == null => GetTargetCopy(original.left, cloned?.left, target),
            not null when original.left == null &&
                          original.right == null => null,
            _ => GetTargetCopy(original.right, cloned?.right, target) ?? GetTargetCopy(original?.left, cloned?.left, target)
        };
}