using System.Collections;

using NUnit.Framework;

namespace PowerOfFour_342_Solution;

public class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(1).Returns(true);
            yield return new TestCaseData(5).Returns(false);
            yield return new TestCaseData(16).Returns(true);
            yield return new TestCaseData(25).Returns(false);
            yield return new TestCaseData(64).Returns(true);
        }
    }
}