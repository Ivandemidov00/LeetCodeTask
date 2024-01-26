using System.Collections;

using NUnit.Framework;

using SolutionHelper;

namespace AllPossibleFullBinaryTrees_894_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            /*yield return new TestCaseData(2).Returns(new List<TreeNode>()
            {
                new TreeNode()
                {
                    
                },
                new TreeNode()
                {
                    
                }
            });*/
            yield return new TestCaseData(3).Returns(new List<TreeNode>()
            {
                new TreeNode()
                {
                    left = new TreeNode(),
                    right = new TreeNode()
                }
            });
        }
        
    }
}