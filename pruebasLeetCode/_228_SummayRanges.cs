using System.Security.Cryptography.X509Certificates;

namespace pruebasLeetCode;
public class _228_SummayRanges
{
    //    0 <= nums.length <= 20
    //-231 <= nums[i] <= 231 - 1
    public IList<string> SummaryRanges(int[] nums)
    {
        var numsL = nums.Length;
        if (numsL > 20 || numsL < 0)
            return new List<string>();
        List<string> result = new();
        int[] helper = new int[numsL];
        int index = 0;
        int count = 0;
        var ongoing = false;

        for (int i = 0; i < numsL; i++)
        {
            count = nums[i + 1] - nums[i];
            if (count > 1)
            {
                helper[i] = nums[i];
                continue;
            }


        }

        do
        {
            if (index == numsL)
                break;
            count = 0;
            count = nums[index + 1] - nums[index];
            if (!ongoing)
            {
                if (count > 1)
                {
                    result.Add(nums[index].ToString());
                    index++;
                    continue;
                }
            }

        } while (true);

        return result;
    }

}
