using SolutionHelper;

// ReSharper disable MemberCanBePrivate.Global

namespace ConvertBinaryNumberInALinkedListToInteger_1290_Solution;

public class SolutionOne : ISolution<ListNode, int>
{
    public int Resolve(ListNode parameters)
    {
        return GetDecimalValue(parameters);
    }

    public int GetDecimalValue(ListNode h)
    {
        ListNode? head = Revert(h);
        double power = 0.0;
        double sum = 0.0;
        while (head != null!)
        {
            if (head.val != 0)
            {
                sum += Math.Pow(2.0, power);
            }

            power++;
            head = head.next!;
        }

        return (int)sum;
    }

    private ListNode Revert(ListNode? listNode)
    {
        if (listNode == null || listNode?.next == null)
        {
            return listNode;
        }

        ListNode? rest = Revert(listNode?.next);
        listNode.next.next = listNode;
        listNode.next = null;

        return rest;
    }
}