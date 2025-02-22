using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasLeetCode;
public class _4_MedianTwoSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> resultList = new List<int>();
        double result;
        foreach (int num in nums1)
            resultList.Add(num);
        foreach (int num in nums2)
            resultList.Add(num);
        resultList.Sort();
        var len = resultList.Count;
        if (len % 2 == 0)
        {
            var index1 = (len - 1) / 2;
            var index2 = (len + 1) / 2;
            result = ((double)resultList[index1] + (double)resultList[index2]) / 2;
            return result;
        }
        else
        {
            var index = len / 2;
            result = resultList[index];
            return result;
        }
        //var list = nums1.ToList();
        //var list2 = nums2.ToList();
        //double result;
        //var resultList = new List<int>();
        //foreach (var item in list)
        //{
        //    resultList.Add(item);
        //}
        //foreach (var item in list2)
        //{
        //    resultList.Add(item);
        //}

        //resultList.Sort();
        //var len = resultList.Count;
        //if (len % 2 == 0)
        //{
        //    var index1 = (len - 1) / 2;
        //    var index2 = (len + 1) / 2;
        //    result = ((double)resultList[index1] + (double)resultList[index2]) / 2;
        //}
        //else
        //{
        //    var index = len / 2;
        //    result = resultList[index];
        //}
    }
}
