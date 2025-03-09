using System.Collections;

using SolutionHelper;

namespace LongestSubstringWithoutRepeatingCharacters_3_Solution;

public class SolutionThree : ISolution<string, int>
{
    public int Resolve(string parameters)
    {
        return parameters.Length switch
        {
            0 => 0,
            1 => 1,
            _ => CalcMaxNonRepeatingSubString(parameters.ToCharArray(), new LinkedListThree())
        };
    }

    private static int CalcMaxNonRepeatingSubString(IReadOnlyList<char> charArray, LinkedListThree bufferMarks,
        int maxNonRepeatingSubString = 0, int iterationStart = 0)
    {
        int currentNonRepeatingSubStrMaxLength = 0;
        int currentNonRepeatingSubStrBufferMaxLength = 0;
        for (int i = iterationStart; i < charArray.Count; i++)
        {
            if (!bufferMarks.TryGetLengthAfterNode(charArray[i], out int node))
            {
                bufferMarks.Add(charArray[i], out currentNonRepeatingSubStrBufferMaxLength);
                currentNonRepeatingSubStrMaxLength++;
            }
            else
            {
                bufferMarks.ChangeHead(node);
                int maxNonRepeatingSubStringBeforeRecursiveCalc = CalcMaxNonRepeatingSubString(charArray, bufferMarks,
                    maxNonRepeatingSubString, currentNonRepeatingSubStrMaxLength + iterationStart);
                return ChoseMaxNonRepeatingSubString(currentNonRepeatingSubStrMaxLength,
                    currentNonRepeatingSubStrBufferMaxLength, maxNonRepeatingSubStringBeforeRecursiveCalc);
            }
        }

        return ChoseMaxNonRepeatingSubString(currentNonRepeatingSubStrMaxLength,
            currentNonRepeatingSubStrBufferMaxLength, maxNonRepeatingSubString);
    }

    private static int ChoseMaxNonRepeatingSubString(int current, int buffer, int maxNonRepeating)
    {
        if (current > maxNonRepeating)
        {
            maxNonRepeating = current;
        }

        if (buffer > maxNonRepeating)
        {
            maxNonRepeating = buffer;
        }

        return maxNonRepeating;
    }


    private sealed class LinkedListThree : IEnumerable<char>
    {
        private Node? _head;
        private int _length;
        private Node? _tail;

        public IEnumerator<char> GetEnumerator()
        {
            Node? current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public void Add(char data, out int currentLengthWithoutRepeat)
        {
            Node node = new(data);
            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.NextNode = node;
                _tail = node;
            }

            _length++;
            currentLengthWithoutRepeat = _length;
        }

        public void ChangeHead(int node)
        {
            _length = node;
        }

        public bool TryGetLengthAfterNode(char data, out int currentMaxNonRepeatingLenght)
        {
            Node? current = _head;
            int lengthBeforeRepeat = 0;
            currentMaxNonRepeatingLenght = 0;
            while (current != null)
            {
                lengthBeforeRepeat++;
                if (current.Data.Equals(data))
                {
                    _head = current.NextNode;
                    currentMaxNonRepeatingLenght = _length - lengthBeforeRepeat;
                    return true;
                }

                current = current.NextNode;
            }

            return false;
        }

        internal sealed class Node
        {
            public Node(char data)
            {
                Data = data;
            }

            public char Data { get; }
            public Node? NextNode { get; set; }
        }
    }
}