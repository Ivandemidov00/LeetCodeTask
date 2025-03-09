using NUnit.Framework;

using SolutionHelper;

namespace GroupAnagrams_49_Solution;

public class Test
{
    private ISolution<Paramters, IList<IList<string>>> _solutionOne = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _solutionOne = new SolutionOne();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.GetData))]
    public IList<IList<string>> SolutionOneTest(Paramters data)
    {
        return _solutionOne.Resolve(data);
    }
}