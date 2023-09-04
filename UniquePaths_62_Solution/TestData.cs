using System.Collections;

using NUnit.Framework;

namespace UniquePaths_62_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(new Parameters(3, 2)).Returns(3);
            yield return new TestCaseData(new Parameters(1, 1)).Returns(1);
            yield return new TestCaseData(new Parameters(2, 2)).Returns(2);
            yield return new TestCaseData(new Parameters(3, 7)).Returns(28);
            yield return new TestCaseData(new Parameters(51, 9)).Returns(1916797311);
            yield return new TestCaseData(new Parameters(3, 3)).Returns(6);
            yield return new TestCaseData(new Parameters(5, 3)).Returns(15);
            
        }
    }
}