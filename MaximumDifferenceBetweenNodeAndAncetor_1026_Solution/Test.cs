using NUnit.Framework;

using SolutionHelper;

namespace MaximumDifferenceBetweenNodeAndAncetor_1026_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<TreeNode, int> _solutionOne = null!;

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionOneTest(TreeNode data)
        => _solutionOne.Resolve(data);
}