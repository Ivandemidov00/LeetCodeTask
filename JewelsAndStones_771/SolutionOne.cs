using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace JewelsAndStones_771;

public class SolutionOne : ISolution<Parameters,int>
{
    public int Resolve(Parameters parameter)
        => NumJewelsInStones(parameter.Jewels, parameter.Stones);
    
    public int NumJewelsInStones(string jewels, string stones)
    {
        short jewelsInStock = 0;
        var jewelsHashSet = jewels.ToHashSet();
        foreach (var _ in stones.Where(@char => jewelsHashSet.Contains(@char)))
        {
            jewelsInStock++;
        }
        return jewelsInStock;
    }
}