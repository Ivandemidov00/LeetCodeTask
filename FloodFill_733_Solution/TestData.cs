using System.Collections;

using NUnit.Framework;

namespace FloodFill_733_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(
                    new Parameter(new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, 1, 1, 2))
                .Returns(new[,] { { 2, 2, 2 }, { 2, 2, 0 }, { 2, 0, 1 } });
        }
    }
}