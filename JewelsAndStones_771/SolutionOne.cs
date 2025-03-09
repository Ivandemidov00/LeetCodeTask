using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace JewelsAndStones_771;

public class SolutionOne : ISolution<Parameters, int>
{
    public int Resolve(Parameters parameters)
    {
        return NumJewelsInStones(parameters.Jewels, parameters.Stones);
    }

    public int NumJewelsInStones(string jewels, string stones)
    {
        short jewelsInStock = 0;
        HashSet<char>? jewelsHashSet = jewels.ToHashSet();
        foreach (char _ in stones.Where(@char => jewelsHashSet.Contains(@char)))
        {
            jewelsInStock++;
        }

        return jewelsInStock;
    }
}