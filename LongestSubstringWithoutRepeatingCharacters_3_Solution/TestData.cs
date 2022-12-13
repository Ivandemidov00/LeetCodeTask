using System.Collections;
using NUnit.Framework;

namespace LongestSubstringWithoutRepeatingCharacters_3_Solution;

public static class TestData
{
    public static IEnumerable GetData
    {
        get
        {
            yield return new TestCaseData("abcabcbb").Returns(3);
            yield return new TestCaseData("bbbbb").Returns(1);
            yield return new TestCaseData("pwwkew").Returns(3);
            yield return new TestCaseData("dvdf").Returns(3);
            yield return new TestCaseData("au").Returns(2);
            yield return new TestCaseData("au").Returns(2);
            yield return new TestCaseData("ohomm").Returns(3);
            yield return new TestCaseData("89!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~ aabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRST").Returns(46);


        }
    }
}