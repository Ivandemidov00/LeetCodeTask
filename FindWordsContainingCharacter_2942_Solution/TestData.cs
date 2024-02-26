using System.Collections;

using NUnit.Framework;

namespace FindWordsContainingCharacter_2942_Solution;

public class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new Parameters(new[] { "abc", "bcd", "aaaa", "cbc" }, 'a'))
                .Returns(new List<int> { 0, 2 });
        }
    }
}