using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasLeetCode
{
    public class NumberContains
    {
        int[] _nums;
        public NumberContains(int[] nums)
        {
            _nums = new int[10];
        }
        public void change(int index, int number)
        {
            _nums[index] = number;
        }
        public int find(int number)
        {
            bool exists = _nums.Contains(number);
            if (exists)
            {
                return Array.IndexOf(_nums, number);
            }
            return -1;
        }
    }
}

