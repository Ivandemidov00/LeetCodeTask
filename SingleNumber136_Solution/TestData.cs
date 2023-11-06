using System.Collections;

using NUnit.Framework;

namespace SingleNumber136_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(new []{4,1,2,1,2})
                .Returns(4);
            yield return new TestCaseData(new []{2,2,1})
                .Returns(1);
        }
    }
}