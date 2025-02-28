using System.Text.RegularExpressions;

namespace pruebasLeetCode;
public class _125_ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        //My solution 35ms
        string pattern = "[^a-zA-Z0-9]";
        s = s.ToLower();
        s = Regex.Replace(s, pattern, "");
        var sLen = s.Length - 1;
        int left = 0, right = sLen;
        while (left <= sLen)
        {
            if (s[left++].Equals(s[right--]))
                continue;
            else
            {
                return false;
            }
        }
        return true;

        //Better solution 11 ms
        //int left = 0;
        //int right = s.Length - 1;
        //while (left < right)
        //{
        //    // Ignorar caracteres no alfanuméricos
        //    while (left < right && !char.IsLetterOrDigit(s[left]))
        //    {
        //        left++;
        //    }
        //    while (left < right && !char.IsLetterOrDigit(s[right]))
        //    {
        //        right--;
        //    }
        //    // Comparar caracteres
        //    if (char.ToLower(s[left]) != char.ToLower(s[right]))
        //    {
        //        return false;
        //    }
        //    left++;
        //    right--;
        //}
        //return true;
    }
}
