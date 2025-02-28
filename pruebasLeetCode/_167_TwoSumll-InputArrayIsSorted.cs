using System.Globalization;

namespace pruebasLeetCode;
class _167_TwoSumll_InputArrayIsSorted
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var numLen = numbers.Length;
        int[] res = new int[2];
        int left = 0, right = numLen - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                res[0] = left + 1;
                res[1] = right + 1;
            }
            if (sum > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return res;
    }
}
