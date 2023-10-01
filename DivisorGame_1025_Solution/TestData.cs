using System.Collections;

using NUnit.Framework;

namespace DivisorGame_1025_Solution;

public static class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(2).Returns(true);
            yield return new TestCaseData(3).Returns(false);
        }
    }
}