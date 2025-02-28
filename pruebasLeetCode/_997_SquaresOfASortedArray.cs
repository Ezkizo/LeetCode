namespace pruebasLeetCode;
public class _997_SquaresOfASortedArray
{
    public int[] SortedSquares(int[] nums)
    {
        int numsLen = nums.Length;
        int[] res = new int[numsLen];
        int right = numsLen - 1, left = 0;
        int index = right;
        while (left <= right)
        {
            var leftVal = nums[left] * nums[left];
            var rightVal = nums[right] * nums[right];
            if (leftVal < rightVal)
            {
                res[index--] = rightVal;
                right--;
            }
            else
            {
                res[index--] = leftVal;
                left++;
            }
        }

        //for (int i = 0; i < numsLen; i++)
        //{
        //    res[i] = nums[i] * nums[i];
        //}
        return res;
    }
}
