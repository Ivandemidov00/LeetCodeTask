using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace LinkedListCycle_141_Solution;

public class SolutionOne : ISolution<ListNode, bool>
{
    public bool Resolve(ListNode parameters)
        => HasCycle(parameters);

    public bool HasCycle(ListNode head)
    {
        return false;
    }
}