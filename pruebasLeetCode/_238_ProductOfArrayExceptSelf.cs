using System.Runtime.CompilerServices;

namespace pruebasLeetCode;
public class _238_ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        //2 ms
        int[] result = new int[nums.Length];
        int preFix = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = preFix;
            preFix = preFix * nums[i];
        }
        int postFix = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] = result[i] * postFix;
            postFix *= nums[i];
        }
        return result;


        /*Mi solución
         * int numsL = nums.Length;
        int[] result = new int[numsL];
        Dictionary<int, int> calc = new();
        int index = 0;
        while (index < nums.Length)
        {
            bool exist = (calc.ContainsKey(nums[index]));
            if (exist)
            {
                calc.TryGetValue(nums[index], out result[index]);
                continue;
            }
            var prod = 1;
            for (int i = 0; i < numsL; i++)
            {
                if (i == index)
                    continue;
                prod *= nums[i];
            }
            result[index] = prod;
            calc.Add(nums[index], prod);
            index++;
        }

        return result;*/
    }
}
