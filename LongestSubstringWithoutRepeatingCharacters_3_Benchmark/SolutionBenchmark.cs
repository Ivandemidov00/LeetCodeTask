using BenchmarkDotNet.Attributes;

using LongestSubstringWithoutRepeatingCharacters_3_Solution;

using SolutionHelper;

namespace LongestSubstringWithoutRepeatingCharacters_3_Benchmark;

public class SolutionBenchmark
{
    private ISolution<string, int> _solutionOne = null!;
    private ISolution<string, int> _solutionThree = null!;
    private ISolution<string, int> _solutionTwo = null!;

    public IEnumerable<string> Data
    {
        get
        {
            yield return "89!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~ aabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRST";
            /*yield return "bbbbb";
            yield return "pwwkew";
            yield return "dvdf";
            yield return "au";
            yield return "ohomm";*/
        }
    }


    [GlobalSetup]
    public void GlobalSetUp()
    {
        _solutionOne = new SolutionOne();
        _solutionTwo = new SolutionTwo();
        _solutionThree = new SolutionThree();
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public void BenchOne(string data)
    {
        _solutionOne.Resolve(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public void BenchTwo(string data)
    {
        _solutionTwo.Resolve(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public void BenchThree(string data)
    {
        _solutionThree.Resolve(data);
    }
}