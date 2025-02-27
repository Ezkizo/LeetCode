using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace pruebasLeetCode;
public class _383_RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (magazine.Length < ransomNote.Length)
            return false;

        var needed = new Dictionary<char, int>();
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (needed.ContainsKey(ransomNote[i]))
            {
                needed[ransomNote[i]]++;
                continue;
            }
            needed.Add(ransomNote[i], 1);
        }

        foreach (var ch in magazine)
        {
            if (needed.ContainsKey(ch))
            {
                if (--needed[ch] == 0)
                    needed.Remove(ch);
            }
        }
        return needed.Values.Count == 0 ? true : false;
    }
}
