using System.Collections;

using NUnit.Framework;

namespace GoalParserInterpretation_1678_Solution;

public static class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData("G()(al)").Returns("Goal");
            yield return new TestCaseData("G()()").Returns("Goo");
            yield return new TestCaseData("G()o").Returns("Goo");
            yield return new TestCaseData("G(o)o").Returns("Goo");
        }
    }
}