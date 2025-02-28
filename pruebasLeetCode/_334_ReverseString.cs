using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace pruebasLeetCode;
public class _334_ReverseString
{
    public void ReverseString(char[] s)
    {
        //PASSED
        int right = s.Length - 1;
        for (int i = 0; i <= right; i++)
        {
            var temp = s[right];
            s[right--] = s[i];
            s[i] = temp;
        }
    }
}
