using NUnit.Framework;

using SolutionHelper;

namespace PascalTriangle_118_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()  
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<int, IList<IList<int>>> _solutionOne = null!;
    
    //[TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public IList<IList<int>> SolutionOneTest(int data)
        => _solutionOne.Resolve(data);                 
}