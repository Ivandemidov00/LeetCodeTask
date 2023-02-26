using NUnit.Framework;
using SolutionHelper;

namespace PalindromeNumber_9_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<int, bool> _solutionOne = null!;
    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public bool SolutionOneTest(int data)
        => _solutionOne.Resolve(data);                 
}