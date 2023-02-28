using System.Collections;
using NUnit.Framework;

namespace DetermineIfTwoEventsHaveConflict_2446_Solution;

public class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData(new Parameters(new []{"01:15","02:00"}, new []{"02:00","03:00"})).Returns(true);
            yield return new TestCaseData(new Parameters(new []{"01:00","02:00"}, new []{"01:20","03:00"})).Returns(true);
            yield return new TestCaseData(new Parameters(new []{"10:00","11:00"}, new []{"14:00","15:00"})).Returns(false);
        }
        
    }
}