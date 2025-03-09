using System.Collections;

using NUnit.Framework;

namespace FinalValueOfVariableAfterPerformingOperations_2011_Solution;

public class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new Parameters(new[] { "--X", "X++", "X++" })).Returns(1);
            yield return new TestCaseData(new Parameters(new[] { "++X", "++X", "X++" })).Returns(3);
        }
    }
}