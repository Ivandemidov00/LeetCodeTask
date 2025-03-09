using SolutionHelper;

namespace MergeTwoSortedLists_21_Solution;

public class SolutionOne : ISolution<Parameters, ListNode>
{
    public ListNode Resolve(Parameters parameters)
    {
        return MergeTwoLists(parameters.List1, parameters.List2);
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null! && list2 == null!)
        {
            return null!;
        }

        if (list1 == null || list2 == null!)
        {
            return list1 == null ? list2! : list1!;
        }

        ListNode resultTemp = new();
        ListNode result = resultTemp;
        do
        {
            if (list1.val < list2.val)
            {
                resultTemp.next = new ListNode(list1.val);
                list1 = list1.next!;
            }
            else
            {
                resultTemp.next = new ListNode(list2.val);
                list2 = list2.next!;
            }

            resultTemp = resultTemp.next!;
        } while (list1 != null! && list2 != null!);

        switch (list1)
        {
            case null when list2 == null:
                return result.next;
            case null:
                resultTemp.next = list2;
                break;
        }

        if (list2 == null)
        {
            resultTemp.next = list1!;
        }

        return result.next!;
    }
}