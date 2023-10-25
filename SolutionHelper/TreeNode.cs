namespace SolutionHelper;

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public override bool Equals(object? obj)
    {
        if(obj is TreeNode treeNode)
            return val == treeNode.val;
        return base.Equals(obj);
    }
}