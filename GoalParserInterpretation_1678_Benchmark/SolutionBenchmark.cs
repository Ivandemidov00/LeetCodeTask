using BenchmarkDotNet.Attributes;

using GoalParserInterpretation_1678_Solution;

using SolutionHelper;

namespace GoalParserInterpretation_1678_Benchmark;

[MemoryDiagnoser]
public class SolutionBenchmark
{
    private ISolution<string, string> _solutionOne = null!;
    private ISolution<string, string> _solutionTwo = null!;

    public IEnumerable<string> Data
    {
        get
        {
            yield return "G()(al)";
            yield return "G()()";
            yield return "G()()oal";
            yield return "G()(y)(t)";
            yield return "G()(al)";
            yield return "G()(al)";
        }
    }


    [GlobalSetup]
    public void GlobalSetUp()
    {
        _solutionOne = new SolutionOne();
        _solutionTwo = new SolutionTwo();
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public void BenchOne(string argument)
    {
        _solutionOne.Resolve(argument);
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public void BenchTwo(string argument)
    {
        _solutionTwo.Resolve(argument);
    }
}