using NUnit.Framework;
using SolutionHelper;

namespace MergeTwoSortedLists_21_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Parameters, ListNode> _solutionOne = null!;
    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public List<int> SolutionOneTest(Parameters data)
        => _solutionOne.Resolve(data).ToList();                 
}