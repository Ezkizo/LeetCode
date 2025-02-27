namespace pruebasLeetCode;
public class _242_ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        int sLen = s.Length, tLen = t.Length;
        if (sLen != tLen)
            return false;
        var dictS = new Dictionary<char, int>();
        var dictT = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (dictS.ContainsKey(ch))
            {
                dictS[ch]++;
                continue;
            }
            dictS.Add(ch, 1);
        }
        foreach (var ch in t)
        {
            if (dictT.ContainsKey(ch))
            {
                dictT[ch]++;
                continue;
            }
            dictT.Add(ch, 1);
        }

        foreach (var ch in t)
        {
            if (dictS.ContainsKey(ch))
                if (--dictS[ch] == 0)
                    dictS.Remove(ch);
        }

        foreach (var ch in s)
        {
            if (dictT.ContainsKey(ch))
                if (--dictT[ch] == 0)
                    dictT.Remove(ch);
        }

        return (dictS.Values.Count == 0 && dictT.Values.Count == 0);
    }
}
