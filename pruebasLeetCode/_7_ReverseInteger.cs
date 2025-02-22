using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace pruebasLeetCode;
public class _7_ReverseInteger
{
    public int Reverse(int x)
    {
        //Mine 29 ms time complexity
        //if (target == int.MinValue)
        //    return 0;
        //bool negative = (target < 0) ? true : false;
        //int res = Math.Abs(target);
        //var charArray = target.ToString().ToCharArray();
        //string formatTarget = string.Empty;
        //for (int i = charArray.Length - 1; i >= 0; i--)
        //{
        //    formatTarget += charArray[i];
        //}
        //try
        //{
        //    res = int.Parse(formatTarget);
        //}
        //catch
        //{
        //    return 0;
        //}
        //if (negative)
        //{
        //    res *= -1;
        //}
        //return res;

        //7ms time complexity
        int rev = 0;
        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;
            if (rev > int.MaxValue / 10 ||
                (rev == int.MaxValue / 10 && pop > 7))
                return 0;
            if (rev < int.MinValue / 10 ||
                (rev == int.MinValue / 10 && pop < -8))
                return 0;
            rev = rev * 10 + pop;
        }

        return rev;
        // -2147483648
    }
}
