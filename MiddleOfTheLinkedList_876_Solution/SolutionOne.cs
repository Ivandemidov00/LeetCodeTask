using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace MiddleOfTheLinkedList_876_Solution;

public class SolutionOne : ISolution<Parameters, ListNode>
{
    public ListNode Resolve(Parameters parameters)
        => MiddleNode(parameters.Head);

    public ListNode MiddleNode(ListNode head)
    {
        if (head.next == null)
        {
            return head;
        }

        ListNode[] nodes = new ListNode[100];
        var iterator = 1;

        while (head.next != null)
        {
            nodes[iterator] = head;
            iterator++;
            head = head.next;
        }

        var middleNodeIter = (iterator / 2) + 1;

        return nodes[middleNodeIter];
    }
}