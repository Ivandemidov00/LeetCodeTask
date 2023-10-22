
using NUnit.Framework;

using SolutionHelper;

namespace FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree_1379_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Parameters, TreeNode> _solutionOne = null!;
    
    [TestCaseSource(typeof(TestData), nameof(TestData.Cases))]
    public TreeNode SolutionOneTest(Parameters command) 
        => _solutionOne.Resolve(command);
}
