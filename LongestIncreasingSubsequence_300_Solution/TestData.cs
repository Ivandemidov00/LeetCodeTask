using System.Collections;

using NUnit.Framework;

namespace LongestIncreasingSubsequence_300_Solution;

public class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new Parameters(new[] { 0, 1, 0, 3, 2, 3 })).Returns(4);
        }
    }
}