using System.Collections;

using NUnit.Framework;

namespace PascalTriangle_118_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(1)
                .Returns(new List<IList<int>> { new List<int> { 1 } });
            yield return new TestCaseData(2)
                .Returns(new List<IList<int>> { new List<int> { 1 }, new List<int> { 1, 1 } });
            yield return new TestCaseData(5).Returns(new List<IList<int>>
            {
                new List<int> { 1 },
                new List<int> { 1, 1 },
                new List<int> { 1, 2, 1 },
                new List<int> { 1, 3, 3, 1 },
                new List<int>
                {
                    1,
                    4,
                    6,
                    4,
                    1
                }
            });
        }
    }
}