using SolutionHelper;

namespace GoalParserInterpretation_1678_Solution;

public class SolutionTwo : ISolution<string, string>
{
    private const char Open = '(';
    private const char Close = ')';

    public string Resolve(string parameters)
    {
        if (parameters.Length == 0)
        {
            return string.Empty;
        }

        List<char>? outputList = new(parameters.Length - 1);
        for (int i = 0; i < parameters.Length; i++)
        {
            if (parameters[i] == Open)
            {
                i++;
                i = FindClose(i, parameters, outputList);
            }
            else
            {
                outputList.Add(parameters[i]);
            }
        }

        return new string(outputList.ToArray());

        static int FindClose(int iterator, string inputAnswer, ICollection<char> outputList)
        {
            if (inputAnswer[iterator - 1] == Open && inputAnswer[iterator] == Close)
            {
                outputList.Add('o');
                return iterator;
            }

            if (inputAnswer[iterator] == Close)
            {
                return iterator;
            }

            outputList.Add(inputAnswer[iterator]);
            iterator++;
            return FindClose(iterator, inputAnswer, outputList);
        }
    }
}