using NUnit.Framework;

using SolutionHelper;

namespace FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree_1379_Solution;

public class Test
{
    private ISolution<Parameters, TreeNode> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [Ignore("link")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public TreeNode SolutionOneTest(Parameters command)
    {
        return _solutionOne.Resolve(command);
    }
}