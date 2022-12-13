using System.Collections;
using SolutionHelper;

namespace LongestSubstringWithoutRepeatingCharacters_3_Solution;

public class SolutionThree : ISolution<string, int>
{
    public int Resolve(string argument)
        => argument.Length switch
        {
            0 => 0,
            1 => 1,
            _ => CalcMaxNonRepeatingSubString(argument.ToCharArray(), new LinkedListThree())
        };
    private static int CalcMaxNonRepeatingSubString(IReadOnlyList<char> charArray, LinkedListThree bufferMarks, int maxNonRepeatingSubString = 0, int iterationStart = 0){
        var currentNonRepeatingSubStrMaxLength = 0;
        var currentNonRepeatingSubStrBufferMaxLength = 0;
        for (var i = iterationStart; i < charArray.Count; i++)
        {
            if (!bufferMarks.TryGetLengthAfterNode(charArray[i], out var node))
            {
                bufferMarks.Add(charArray[i], out currentNonRepeatingSubStrBufferMaxLength);
                currentNonRepeatingSubStrMaxLength++;
            }
            else
            { 
                bufferMarks.ChangeHead(node);
                var maxNonRepeatingSubStringBeforeRecursiveCalc = CalcMaxNonRepeatingSubString(charArray, bufferMarks, maxNonRepeatingSubString, currentNonRepeatingSubStrMaxLength + iterationStart);
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
        internal sealed class Node
        {
            public Node(char data)
                => Data = data;
            public char Data { get; set; }
            public Node? NextNode { get; set; } = null;
        };
        
        private Node? _head;
        private Node? _tail;
        private int _length;


        public void Add(char data, out int currentLengthWithoutRepeat)
        {
            var node = new Node(data);
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
            var current = _head;
            var lengthBeforeRepeat = 0;
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
        public IEnumerator<char> GetEnumerator()
        {
            var current = _head;
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
    }
}