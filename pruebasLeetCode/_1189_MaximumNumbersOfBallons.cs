namespace pruebasLeetCode;
public class _1189_MaximumNumbersOfBallons
{
    public int MaxNumberOfBalloons(string text)
    {
        int minLen = "balloon".Length;
        int textLen = text.Length;
        if (textLen < minLen)
            return 0;
        var dict = new Dictionary<char, int>
                   {
                       { 'b', 0 },
                       { 'a', 0 },
                       { 'l', 0 },
                       { 'o', 0 },
                       { 'n', 0 }
                   };

        foreach (var ch in text)
        {
            if (dict.ContainsKey(ch))
            {
                dict[ch]++;
            }
        }
        var minValue = int.MaxValue;
        foreach (var val in dict.Keys)
        {
            if (dict[val] == 0)
                return 0;
            if (val.Equals('l') || val.Equals('o'))
            {
                minValue = dict[val] / 2 < minValue ? dict[val] / 2 : minValue;
                continue;
            }
            if (dict[val] < minValue)
            {
                minValue = dict[val];
            }
        }
        return minValue;
    }
}
