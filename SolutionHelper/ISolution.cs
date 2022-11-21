namespace SolutionHelper;

public interface ISolution<in TInput, out TOutput>
{
    public TOutput Resolve(TInput argument);
}