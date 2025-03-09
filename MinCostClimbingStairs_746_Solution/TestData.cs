using System.Collections;

using NUnit.Framework;

namespace MinCostClimbingStairs_746_Solution;

public static class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new[] { 10, 15, 20 }).Returns(15);
        }
    }
}