namespace SolutionHelper;

public static class ListNodeExtension
{
    public static List<int> ToList(this ListNode listNode, List<int>? sumList = null!)
    {
        if (sumList is null)
        {
            List<int> newSumList = new() { listNode.val };
            if (listNode.next == null)
            {
                return newSumList;
            }

            listNode = listNode.next;
            return listNode.ToList(newSumList);
        }

        sumList.Add(listNode.val);
        if (listNode.next == null)
        {
            return sumList;
        }

        listNode = listNode.next;
        return listNode.ToList(sumList);
    }
}