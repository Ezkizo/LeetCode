using System.Security.Cryptography;

namespace pruebasLeetCode;
public class _15_3Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        /*      Example 1:
        Input: nums = [-1, 0, 1, 2, -1, -4]
        Output: [[-1,-1,2],[-1,0,1]]
        Explanation:
                nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
                nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
                nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are[-1, 0, 1] and[-1, -1, 2].
        Notice that the order of the output and the order of the triplets does not matter.*/

        var len = nums.Length;
        if (len < 3 || len > 3000)
            return [];

        var result = new List<IList<int>>();
        var helper = 0;
        var helpArray = new int[] { 0, 0, 0 };
        var indexHelper = 0;
        for (int i = 0; i < len; i++)
        {
            //if (nums[i] < -100000 || nums[i] > 100000)
            //    continue;
            
            //if ()
            //{

            //}
        }

        return result;
    }
}
