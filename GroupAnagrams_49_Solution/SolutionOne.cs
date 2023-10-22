using SolutionHelper;

namespace GroupAnagrams_49_Solution;

public class SolutionOne : ISolution<Paramters,IList<IList<string>>>
{
    public IList<IList<string>> Resolve(Paramters parameters)
        => GroupAnagrams(parameters.strs);

    private static readonly Func<string[], bool> IsExteremCase = strs => strs.Length == 1;
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        if(IsExteremCase(strs))
            return new List<IList<string>> { strs };
        
        return new List<IList<string>>();
    }
}