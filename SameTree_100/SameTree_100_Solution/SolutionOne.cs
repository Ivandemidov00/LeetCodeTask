using SolutionHelper;

namespace SameTree_100_Solution;

public class SolutionOne : ISolution<Parameters, bool>
{
    public bool Resolve(Parameters parameters)
    {
        return IsSameTree(parameters.p, parameters.q);
    }

    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (Equals(p, null) || Equals(q, null))
        {
            return Equals(p, q);
        }

        if (!p.val.Equals(q.val))
        {
            return false;
        }

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}