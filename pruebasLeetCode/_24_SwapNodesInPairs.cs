namespace pruebasLeetCode;
public class _24_SwapNodesInPairs
{
    //PASSED
    public ListNode SwapPairs(ListNode head)
    {
        if (head is null) return null;
        if (head.next is null) return head;
        ListNode result = new(), current = result;
        ListNode queue;
        while (head != null && head.next != null)
        {
            queue = head.next.next;
            current.next = new(head.next.val);
            current = current.next;
            current.next = new(head.val);
            current = current.next;

            head = queue;

        }
        if (head is not null)
            current.next = new(head.val);

        return result.next;
    }
}
