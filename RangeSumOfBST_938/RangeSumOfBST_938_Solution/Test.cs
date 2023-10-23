using System.Reflection.Metadata;

using NUnit.Framework;

using SolutionHelper;

namespace RangeSumOfBST_938_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Parameters, int> _solutionOne = null!;
    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public int SolutionOneTest(Parameters parameters) 
        => _solutionOne.Resolve(parameters);
}
