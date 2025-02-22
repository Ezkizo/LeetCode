namespace pruebasLeetCode;
public class _13_RomanToInteger
{
    public int RomanToInt(string s)
    {
        if (s.Length < 1 || s.Length > 15)
            return 0;

        char[] chars = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        int[] values = { 1, 5, 10, 50, 100, 500, 1000 };
        int lvlIndex = chars.Length - 1;

        var charArray = s.ToCharArray();
        int result = 0;

        for (int i = 0; i < charArray.Length; i++)
        {
            while (true)
            {
                if (chars[lvlIndex].Equals(charArray[i]))
                {
                    if (i < charArray.Length && i + 1 < charArray.Length)
                    {
                        var charNextItem = charArray[i + 1];
                        var indexNextChar = Array.IndexOf(chars, charNextItem);

                        if (indexNextChar > lvlIndex)
                        {
                            result += values[indexNextChar] - values[lvlIndex];
                            lvlIndex--;
                            i++;
                            break;
                        }
                    }
                    result += values[lvlIndex];
                }
                else
                {
                    lvlIndex--;
                    continue;
                }
                break;
            }
        }
        return result;
    }
}
