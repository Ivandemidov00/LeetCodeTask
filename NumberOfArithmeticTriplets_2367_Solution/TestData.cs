using System.Collections;

using NUnit.Framework;

namespace NumberOfArithmeticTriplets_2367_Solution;

public static class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new Parameters(new[] { 4, 5, 6, 7, 8, 9 }, 2)).Returns(2);
        }
    }
}