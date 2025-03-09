using NUnit.Framework;

namespace TwoSum_1_Solution;

public class Test
{
    private SolutionOne _solutionOne = null!;
    private SolutionTwo _solutionTwo = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
        _solutionTwo = new SolutionTwo();
    }

    [TestCaseSource(typeof(TestData))]
    public void TestOneExample(int[] nums, int target, int[] expected)
    {
        int[]? result = _solutionOne.TwoSum(nums, target);
        Assert.AreEqual(result, expected);
    }

    [TestCaseSource(typeof(TestData))]
    public void TestTwoExample(int[] nums, int target, int[] expected)
    {
        int[]? result = _solutionTwo.TwoSum(nums, target);
        Assert.AreEqual(result, expected);
    }
}