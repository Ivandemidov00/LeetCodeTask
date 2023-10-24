using System.Reflection.Metadata;

using NUnit.Framework;

using SolutionHelper;

namespace RootEqualsSumOfChildren_2236_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<TreeNode, bool> _solutionOne = null!;
    
    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public bool SolutionOneTest(TreeNode command) 
        => _solutionOne.Resolve(command);
}
