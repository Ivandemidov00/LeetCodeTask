using SolutionHelper;

namespace GoalParserInterpretation_1678_Solution;

public class SolutionOne : ISolution<string, string>
{
    private const char Open = '(';
    private const char Close = ')';

    public string Resolve(string parameter)
    {
        if (parameter.Length == 0)
            return string.Empty;
        var inputArray = parameter.ToCharArray();
        var outputList  = new List<char>();
        for (var i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] == Open)
            {
                i++;
                i = FindClose(i, inputArray, outputList);
            }
            else
            {
                outputList.Add(parameter[i]);
            }
        }

        return new string(outputList.ToArray());

        static int FindClose(int iterator, IReadOnlyList<char> inputAnswer, IList<char> outputList)
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