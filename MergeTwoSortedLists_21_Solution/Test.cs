using NUnit.Framework;

using SolutionHelper;

namespace MergeTwoSortedLists_21_Solution;

public class Test
{
    private ISolution<Parameters, ListNode> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public List<int> SolutionOneTest(Parameters data)
    {
        return _solutionOne.Resolve(data).ToList();
    }
}