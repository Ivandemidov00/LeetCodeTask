using System.Collections;

using SolutionHelper;

namespace LongestSubstringWithoutRepeatingCharacters_3_Solution;

public class SolutionTwo : ISolution<string, int>
{
    public int Resolve(string parameters)
    {
        return parameters.Length switch
        {
            0 => 0,
            1 => 1,
            _ => CalcMaxNonRepeatingSubString(parameters.ToCharArray(), new LinkedListTwo(), 0)
        };
    }

    private static int CalcMaxNonRepeatingSubString(char[] charArray, LinkedListTwo bufferMarksList,
        int maxNonRepeatingSubString, int iterationStart = 0)
    {
        int currentNonRepeatingSubStrMaxLength = 0;
        int currentNonRepeatingSubStrBufferMaxLength = 0;
        for (int i = iterationStart; i < charArray.Length; i++)
        {
            if (!bufferMarksList.TryGetLengthAfterNode(charArray[i], out LinkedListTwo.Node? node))
            {
                bufferMarksList.Add(charArray[i], out currentNonRepeatingSubStrBufferMaxLength);
                currentNonRepeatingSubStrMaxLength++;
            }
            else
            {
                int maxNonRepeatingSubStringBeforeRecursiveCalc = CalcMaxNonRepeatingSubString(charArray,
                    new LinkedListTwo(node), maxNonRepeatingSubString,
                    currentNonRepeatingSubStrMaxLength + iterationStart);
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


    private sealed class LinkedListTwo : IEnumerable<char>
    {
        private Node? _head;
        private int _length;
        private int _lengthBeforeRepeat;
        private Node? _tail;

        public LinkedListTwo()
        {
        }

        public LinkedListTwo(Node currentHead)
        {
            _length = 0;
            _head = currentHead;
            _tail = FindLast(currentHead);
        }

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
            Node? node = new(data);
            if (_head == null || _tail == null)
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


        public bool TryGetLengthAfterNode(char data, out Node? currentHead)
        {
            Node? current = _head;
            currentHead = _head;
            int underCurrent = 0;
            _lengthBeforeRepeat = 0;
            while (current != null)
            {
                underCurrent++;
                if (current.Data.Equals(data))
                {
                    _lengthBeforeRepeat = underCurrent;
                    _head = current.NextNode;
                    currentHead = _head;
                    return true;
                }

                current = current.NextNode;
            }

            currentHead = _head;
            return false;
        }

        private Node FindLast(Node node)
        {
            Node? currentLast = node;

            while (node != null)
            {
                currentLast = node;
                node = node.NextNode;
                _length++;
            }

            return currentLast;
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