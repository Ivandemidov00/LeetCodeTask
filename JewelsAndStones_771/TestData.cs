using System.Collections;

using NUnit.Framework;

namespace JewelsAndStones_771;

public static class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new Parameters("aA", "aAAbbbb")).Returns(3);
            yield return new TestCaseData(new Parameters("z", "ZZ")).Returns(0);
            yield return new TestCaseData(new Parameters("zZZ", "ZZ")).Returns(2);
            yield return new TestCaseData(new Parameters("z", "ZZ")).Returns(0);
        }
    }

}