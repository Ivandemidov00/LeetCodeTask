using System.Reflection.Metadata.Ecma335;

using SolutionHelper;

namespace IsomorphicStrings_205_Solution;

public class SolutionOne : ISolution<Parameters, bool>
{
    public bool Resolve(Parameters parameters)
    {
        Dictionary<char, char> characters = new Dictionary<char, char>();
        int length = parameters.S.Length;

        for (int i = 0; i < length; i++)
        {
            if (characters.ContainsKey(parameters.S[i]))
            {
                if (characters[parameters.S[i]] != parameters.T[i]) return false;
                continue;
            }
            else if (characters.ContainsValue(parameters.T[i])) return false;

            characters[parameters.S[i]] = parameters.T[i];
        }

        return true;
    }
}