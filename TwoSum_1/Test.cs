using NUnit.Framework;

namespace TwoSum_1;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solution = new Solution();
    }

    private Solution _solution = null!;
    [TestCaseSource(typeof(TestData))]
    public void TestExample(int[] nums, int target, int[] expected)
    {
        var result = _solution.TwoSum(nums, target);
        Assert.AreEqual(result, expected);
    }
}