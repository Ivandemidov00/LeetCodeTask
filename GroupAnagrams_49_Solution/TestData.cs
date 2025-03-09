using System.Collections;

using NUnit.Framework;

namespace GroupAnagrams_49_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(new Paramters(new[] { "" })).Returns(
                new List<IList<string>> { new List<string> { "" } });
        }
    }
}