namespace pruebasLeetCode;
public class _5_LongestPalindromic
{
    public string LongestPalindrome(string s)
    {
        var r = string.Empty;
        var n = s.Length;
        string pal = string.Empty;
        var stgn = s.ToCharArray();
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (var i = 0; i < n; i++)
        {
            dict.Add(stgn[i], 1);
        }





        return string.Empty;
    }
}
