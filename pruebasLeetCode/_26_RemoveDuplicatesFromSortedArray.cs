using System.Security.Cryptography.X509Certificates;

namespace pruebasLeetCode;
class _26_RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        int res = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[res] = nums[i];
                res++;
            }
        }
        return res;
    }

}
