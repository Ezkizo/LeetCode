using System.Security.Cryptography.X509Certificates;

namespace pruebasLeetCode;
public class _21_MergeTwoSortedLists
{
    public class ListNodeM
    {
        public int val;
        public ListNodeM next;
        public ListNodeM(int val = 0, ListNodeM next = null)
        {
            this.val = val;
            this.next = next;

        }
    }
    //PASSED
    public ListNodeM MergeTwoLists(ListNodeM list1, ListNodeM list2)
    {
        if (list1 is null)
            return list2;
        if (list2 is null)
            return list1;

        ListNodeM result = new(0);
        ListNodeM current = result;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = new(list1.val);
                list1 = list1.next;
            }
            else
            {
                current.next = new(list2.val);
                list2 = list2.next;
            }

            current = current.next;
        }
        while (list1 != null)
        {
            current.next = new(list1.val);
            list1 = list1.next;
            current = current.next;
        }
        while (list2 != null)
        {
            current.next = new(list2.val);
            list2 = list2.next;
            current = current.next;
        }

        return result.next;
    }

}
