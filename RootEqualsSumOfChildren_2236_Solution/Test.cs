using NUnit.Framework;

using SolutionHelper;

namespace RootEqualsSumOfChildren_2236_Solution;

public class Test
{
    private ISolution<TreeNode, bool> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public bool SolutionOneTest(TreeNode command)
    {
        return _solutionOne.Resolve(command);
    }
}