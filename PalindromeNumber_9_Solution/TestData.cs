using System.Collections;
using NUnit.Framework;

namespace PalindromeNumber_9_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(-101).Returns(false);
            yield return new TestCaseData(0).Returns(true);
            yield return new TestCaseData(101).Returns(true);
            yield return new TestCaseData(1011).Returns(false);

        }
    }
}