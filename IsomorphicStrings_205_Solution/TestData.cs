using System.Collections;

using NUnit.Framework;

namespace IsomorphicStrings_205_Solution;

public class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new Parameters("egg", "add")).Returns(true);
        }
    }
}