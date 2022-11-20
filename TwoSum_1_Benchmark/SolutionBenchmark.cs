using BenchmarkDotNet.Attributes;

namespace TwoSum_1_Benchmark;

[MemoryDiagnoser]
public class SolutionBenchmark
{
    private readonly SolutionOne _solutionOne = new();

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public void Bench(int[] nums, int target)
    {
        _solutionOne.TwoSum(nums, target);
    }
    
    public IEnumerable<object[]> Data()
    {
        yield return new object[]
        {
            new[] { 2, 7, 11, 15 },
            9,
        };
        yield return new object[]
        {
            new[] { 3, 2, 4 },
            6,
        };
        yield return new object[]
        {
            new[] { -8, -7, 11, 15 },
            -15,
        };
    }
}