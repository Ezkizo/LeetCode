
using static pruebasLeetCode._21_MergeTwoSortedLists;

namespace pruebasLeetCode;
static class Program
{
    static void Main(string[] args)
    {
        /* PASSED
        var obj = new _4_MedianTwoSortedArrays();
        int[] val = { 1, 2 };
        int[] val2 = { 3, 4 };
        obj.FindMedianSortedArrays(val, val2);*/

        /*PENDIENTE
        var obj = new _15_3Sum();
        obj.ThreeSum([-1, 0, 1, 2, -1, -4]);
        obj.ThreeSum([0, 1, 1]);
        obj.ThreeSum([0, 0, 0]);*/

        /*PENDIENTE TIEMPO SUPERADO
        var obj = new _20_ValidParentheses();
        obj.IsValid("()");
        Pendiente => obj.IsValid("({{{{}}}))");
        obj.IsValid("()[]{}");
        obj.IsValid("([)]");*/

        /*PASSED
        var obj = new _21_MergeTwoSortedLists();

        var first1 = new ListNodeM(1, new ListNodeM(2, new ListNodeM(4)));
        var first2 = new ListNodeM(1, new ListNodeM(3, new ListNodeM(4)));
        var second1 = new ListNodeM(2);
        var second2 = new ListNodeM(1);
        //obj.MergeTwoLists(first1, first2);
        obj.MergeTwoLists(second1, second2);*/

        /*PASSED
        var obj = new _392_IsSubsequence();
        obj.IsSubsequence("abc", "ahbgdc");*/

        /*Pendiente tiempo máximo superado
        var obj = new _228_SummayRanges();
        obj.SummaryRanges([0, 1, 2, 4, 5, 7]);*/

        /*PASSED 
        var obj = new _238_ProductOfArrayExceptSelf();
        obj.ProductExceptSelf([1, 2, 3, 4]);
        */

        /*En progreso SEMI PASS checar algunos tests 
        var obj = new _56_MergeIntervals();
        obj.Merge([[1, 4], [5, 6]]);
        obj.Merge([[1, 3], [2, 6], [8, 10], [15, 18]]);
        */

        /* PASSED
        var obj = new _26_RemoveDuplicatesFromSortedArray();
        obj.RemoveDuplicates([1, 1, 2]);
        */

        /* PASSED
        var obj = new _54_SpiralMatrix();
        obj.SpiralOrder([[2, 3, 4], [5, 6, 7], [8, 9, 10], [11, 12, 13], [14, 15, 16]]);
        */

        var obj = new _48_RotateImage();
        obj.Rotate([[1, 2, 3], [4, 5, 6], [7, 8, 9]]);
    }
}


