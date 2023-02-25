using System.Collections;
using NUnit.Framework;

namespace ClimbingStairs_70_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(2).Returns(2);
            yield return new TestCaseData(3).Returns(3);
        }
        
    }
}