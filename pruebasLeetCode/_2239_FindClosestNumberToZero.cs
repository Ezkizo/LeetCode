using System.Collections;

namespace pruebasLeetCode;
public class _2239_FindClosestNumberToZero
{
    public int FindClosestNumber(int[] nums)
    {
        int result = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (Math.Abs(result) >= Math.Abs(nums[i]))
            {
                result = nums[i];
            }
        }
        if (nums.Contains(-result))
        {
            return (result > 0) ? result : -result;
        }

        return result;
    }
}
