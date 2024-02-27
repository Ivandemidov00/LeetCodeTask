using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace AllPossibleFullBinaryTrees_894_Solution;

public class SolutionOne : ISolution<int,IList<TreeNode>>
{
    private readonly Dictionary<int, List<TreeNode>> _nodes = new();
    public IList<TreeNode> Resolve(int parameters)
        => AllPossibleFBT(parameters);
    public IList<TreeNode> AllPossibleFBT(int n)
    {
        switch (n)
        {
            case 0:
                return new List<TreeNode>();
            case 1:
                return new List<TreeNode> { new() };
        }

        if (_nodes.TryGetValue(n, out var nodes))
            return nodes;
        List<TreeNode> result = new();
        for (int i = 0; i < n; i++)
        {
            var r = n - 1 - i;
            var leftTree = AllPossibleFBT(i);
            var rightTree = AllPossibleFBT(r);
            foreach (var leftTreeNode in leftTree)
            {
                foreach (var rightTreeNode in rightTree)
                {
                    result.Add(new TreeNode(0, leftTreeNode, rightTreeNode));
                }
            }

            _nodes[n] = result;
        }

        return result;
    }
}