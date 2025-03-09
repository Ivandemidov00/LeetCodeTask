using NUnit.Framework;

using SolutionHelper;

namespace MergeTwoBinaryTrees_617_Solution;

public class Test
{
    private ISolution<Parameters, TreeNode> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public TreeNode SolutionOneTest(Parameters parameters)
    {
        return _solutionOne.Resolve(parameters);
    }
}