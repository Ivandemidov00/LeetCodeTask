using System.Collections;
using SolutionHelper;

namespace LongestSubstringWithoutRepeatingCharacters_3_Solution;

public class SolutionOne : ISolution<string, int>
{
    /*
    public int Resolve(string argument)
    {
        int nonRepeatingSubStrMaxLength = 0;
        int currentNonRepeatingSubStrMaxLength = 0;
        var charArray = argument.ToCharArray();
        var bufferMarksList = new List<char>();
        foreach (var element in charArray)
        {
            if (!bufferMarksList.Contains(element))
            {
                bufferMarksList.Add(element);
                currentNonRepeatingSubStrMaxLength++;
            }
            else
            {
                if(nonRepeatingSubStrMaxLength < currentNonRepeatingSubStrMaxLength)
                    nonRepeatingSubStrMaxLength = currentNonRepeatingSubStrMaxLength;
                currentNonRepeatingSubStrMaxLength = 1;
                bufferMarksList.Clear();
                bufferMarksList.Add(element);
            }
        }

        if(nonRepeatingSubStrMaxLength < currentNonRepeatingSubStrMaxLength)
            nonRepeatingSubStrMaxLength = currentNonRepeatingSubStrMaxLength;
        return (int)nonRepeatingSubStrMaxLength;
    }
    */

    public int Resolve(string argument)
        => argument.Length switch
        {
            0 => 0,
            1 => 1,
            _ => CalcMaxNonRepeatingSubString(argument.ToCharArray(), new LinkedList(), 0)
        };
    private static int CalcMaxNonRepeatingSubString(char[] charArray, LinkedList bufferMarksList, int maxNonRepeatingSubString){
        var currentNonRepeatingSubStrMaxLength = 0;
        var currentNonRepeatingSubStrBufferMaxLength = 0;
        foreach (var element in charArray)
        {
            if (!bufferMarksList.TryGetLengthAfterNode(element, out var node))
            {
                bufferMarksList.Add(element, out currentNonRepeatingSubStrBufferMaxLength);
                currentNonRepeatingSubStrMaxLength++;
            }
            else
            { 
                var maxNonRepeatingSubStringBeforeRecursiveCalc = CalcMaxNonRepeatingSubString(charArray[currentNonRepeatingSubStrMaxLength..], new LinkedList(node), maxNonRepeatingSubString);
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


    private sealed class LinkedList : IEnumerable<char>
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
        private int _lengthBeforeRepeat = 0;

        public LinkedList()
        {
        }

        public LinkedList(Node currentHead)
        {
            _length = 0;
            _head = currentHead;
            _tail = FindLast(currentHead);
        }

        public void Add(char data, out int currentLengthWithoutRepeat)
        {
            var node = new Node(data);
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
            var current = _head;
            currentHead = _head;
            var underCurrent = 0;
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
            var currentLast = node;
            
            while (node != null)
            {
                currentLast = node;
                node = node.NextNode;
                _length++;
            }
            
            return currentLast;
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