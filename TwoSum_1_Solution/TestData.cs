using System.Collections;

namespace TwoSum_1_Solution;

public class TestData : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        yield return new object[]
        {
            new[] { 2, 7, 11, 15 },
            9,
            new[] { 0, 1 }
        };
        yield return new object[]
        {
            new[] { 3, 2, 4 },
            6,
            new[] { 1, 2 }
        };
        yield return new object[]
        {
            new[] { -8, -7, 11, 15 },
            -15,
            new[] { 0, 1 }
        };
    }
}