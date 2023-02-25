using NUnit.Framework;
using SolutionHelper;

namespace GroupAnagrams_49_Solution;

public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    private ISolution<Paramters, IList<IList<string>>> _solutionOne = null!;
    
    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public IList<IList<string>> SolutionOneTest(Paramters data)
        => _solutionOne.Resolve(data);
}