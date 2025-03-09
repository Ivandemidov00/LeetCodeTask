using NUnit.Framework;

using SolutionHelper;

namespace MaximumDifferenceBetweenNodeAndAncetor_1026_Solution;

public class Test
{
    private ISolution<TreeNode, int> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionOneTest(TreeNode data)
    {
        return _solutionOne.Resolve(data);
    }
}