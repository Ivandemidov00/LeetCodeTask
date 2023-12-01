using System.Collections;

using NUnit.Framework;

namespace EvaluateReversePolishNotation_150_Solution;

public static class TestData
{
    public static IEnumerable Cases
    {
        get
        {
            yield return new TestCaseData(new Parameters(new []{"4", "13", "5", "/", "+"})).Returns(6);
        }
    }
}