namespace pruebasLeetCode;
public class _23_MergeKSortedLists
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        ListNode dummyHead = new(), result = dummyHead;
        List<int> res = new();
        for (int index = 0; index < lists.Length; index++)
        {
            while (lists[index] != null)
            {
                res.Add(lists[index].val);
                lists[index] = lists[index].next;
            }
        }

        res.Sort();

        foreach (var i in res)
        {
            dummyHead.next = new(i);
            dummyHead = dummyHead.next;
        }

        return result.next;
    }
}
