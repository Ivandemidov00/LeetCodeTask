using System.Collections;

using NUnit.Framework;

namespace IntegerToRoman_12_Solution;

public static class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(3).Returns("III");
            yield return new TestCaseData(1994).Returns("MCMXCIV");
        }
    }
}