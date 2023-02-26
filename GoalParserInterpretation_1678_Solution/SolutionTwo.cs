using SolutionHelper;

namespace GoalParserInterpretation_1678_Solution;

public class SolutionTwo : ISolution<string, string>
{
    private const char Open = '(';
    private const char Close = ')';

    public string Resolve(string parameter)
    {
        if (parameter.Length == 0)
            return string.Empty;
        var outputList  = new List<char>(parameter.Length - 1);
        for (var i = 0; i < parameter.Length; i++)
        {
            if (parameter[i] == Open)
            {
                i++;
                i = FindClose(i, parameter, outputList);
            }
            else
            {
                outputList.Add(parameter[i]);
            }
        }

        return new string(outputList.ToArray());

        static int FindClose(int iterator, string inputAnswer, ICollection<char> outputList)
        {
            if (inputAnswer[iterator-1] == Open && inputAnswer[iterator] == Close)
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