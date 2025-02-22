namespace pruebasLeetCode;
public class _392_IsSubsequence
{
    //PASSED 0MS
    public bool IsSubsequence(string s, string t)
    {
        if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
            return true;
        bool result = false;
        int index = 0;
        int sIndex = 0;
        int tLen = t.Length;
        int sLen = s.Length;
        while (index < tLen)
        {
            if (sIndex == sLen)
                return true;
            if (s[sIndex].Equals(t[index]))
            {
                result = true;
                index++;
                sIndex++;
                continue;
            }
            index++;
            result = false;
        }

        if (sIndex != sLen)
            return false;

        return result;
    }
}
