using System.Collections;

using NUnit.Framework;

namespace CountingBits_338_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(2).Returns(new int[]{0,1,1});
            yield return new TestCaseData(5).Returns(new int[]{0,1,1,2,1,2});
        }
    }
}