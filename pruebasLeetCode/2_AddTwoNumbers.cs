namespace pruebasLeetCode;
public class _2_AddTwoNumbers
{
    /*public int[] AddTwoNumbers(int[] l1, int[] l2)
    {
        int[] _l1 = l1;
        int[] _l2 = l2;
        var l1value = string.Empty;
        var l2value = string.Empty;
        for (int i = l1.Length - 1; i >= 0; i--)
        {
            l1value += l1[i].ToString();
        }
        for (int i = l2.Length - 1; i >= 0; i--)
        {
            l2value += l2[i].ToString();
        }
        var total = int.Parse(l1value) + int.Parse(l2value);
        var d = total.ToString().ToCharArray();
        var contador = d.Length;
        int[] result = new int[contador];
        for (int i = 0; i < contador; i++)
        {
            result[i] = int.Parse(d[i].ToString());
        }
        return result;
    }*/
    public ListNode AddTwoNumbersLinked(ListNode l1, ListNode l2)
    {
        /*ListNode dummyHead = new ListNode(0);
        ListNode p = l1, q = l2, current = dummyHead;
        int carry = 0;
        while (p != null || q != null)
        {
            int x = (p != null) ? p.val : 0;
            int y = (q != null) ? q.val : 0;
            int sum = carry + x + y;
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
            if (p != null) p = p.next;
            if (q != null) q = q.next;
        }
        if (carry > 0)
        {
            current.next = new ListNode(carry); 
        }
        return dummyHead.next;*/

        ListNode result = new(0);
        ListNode list1 = l1, list2 = l2, current = result;
        int carry = 0;
        while (list1 != null || list2 != null)
        {
            int x = (list1 != null) ? list1.val : 0;
            int y = (list2 != null) ? list2.val : 0;
            int sum = x + y + carry;
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
            if (list1 != null) list1 = list1.next;
            if (list2 != null) list2 = list2.next;
        }
        if (carry > 0)
        {
            current.next = new ListNode(carry);
        }
        return result.next;


    }
}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}