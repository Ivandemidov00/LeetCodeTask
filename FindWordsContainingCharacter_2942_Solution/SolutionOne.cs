using SolutionHelper;

namespace FindWordsContainingCharacter_2942_Solution;

public class SolutionOne : ISolution<Parameters,IList<int>>
{
    public IList<int> Resolve(Parameters parameters)
    {
        var result = new List<int>();
        for(var i = 0; i < parameters.Words.Length; i++)
        {
            if(parameters.Words[i].Contains(parameters.X))
            {
                result.Add(i);
            }
        }
        return result;
    }
}