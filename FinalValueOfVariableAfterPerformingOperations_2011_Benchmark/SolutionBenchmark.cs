using BenchmarkDotNet.Attributes;

using FinalValueOfVariableAfterPerformingOperations_2011_Solution;

using SolutionHelper;

namespace FinalValueOfVariableAfterPerformingOperations_2011_Benchmark;

public class SolutionBenchmark
{
    private ISolution<Parameters, int> _solutionOne = null!;
    private ISolution<Parameters, int> _solutionTwo = null!;

    [GlobalSetup]
    public void GlobalSetUp()
    {
        _solutionOne = new SolutionOne();
        _solutionTwo = new SolutionTwo();
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public void BenchOne(Parameters data)
    {
        _solutionOne.Resolve(data);
    }
    
    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public void BenchTwo(Parameters data)
    {
        _solutionTwo.Resolve(data);
    }

    public IEnumerable<Parameters> Data
    {
        get
        {
            yield return new Parameters(new[]
            {
                "--X","X++","X++",
                "--X","X++","X++",
                "--X","X++","X++",
                "--X","X++","X++",
                "--X","X++","X++",
                "--X","X++","X++",
                "--X","X++","X++",
                "--X","X++","X++",
                "++X","X++","X++",
                "++X","X++","X++",
                "++X","X++","X++",
                "++X","X++","X++",
                "++X","X++","X++",
                "++X","X++","X++",
                "++X","X++","X++",
                "++X","X++","X++"
            });
        }
    }
}