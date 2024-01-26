using NUnit.Framework;

using SolutionHelper;

namespace AllPossibleFullBinaryTrees_894_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<int, IList<TreeNode>> _solutionOne = null!;
    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public IList<TreeNode> SolutionOneTest(int command) 
        => _solutionOne.Resolve(command);
}