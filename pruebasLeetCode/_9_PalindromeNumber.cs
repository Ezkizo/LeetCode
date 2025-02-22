using System.Data;

namespace pruebasLeetCode;
public class _9_PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        //1ms Time Solution
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;
        int reverse = 0;
        while (x > reverse)
        {
            reverse = reverse * 10 + x % 10;
            x /= 10;
        }

        return x == reverse || x == reverse / 10;

        //Mine 7 ms Solution
        //var toCharArray = x.ToString().ToCharArray();
        //char[] sorted = new char[toCharArray.Length];
        //string evaluate = string.Empty;
        //var len = toCharArray.Length;
        //for (int i = 0; i < sorted.Length; i++)
        //{
        //    evaluate += toCharArray[len - 1];
        //    len--;
        //}

        //if (evaluate.Equals(x.ToString()))
        //    return true;

        //return false;
    }
}
