using Microsoft.VisualBasic;

namespace pruebasLeetCode;
public class _1768_MergeStringsAlternately
{
    //    You are given two strings word1 and word2.Merge the strings by adding letters in alternating order,
    //    starting with word1. If a string is longer than the other,
    //    append the additional letters onto the end of the merged string.
    //    Return the merged string.
    public string MergeAlternately(string word1, string word2)
    {
        string res = string.Empty;
        int index = 0;
        int lenWord1 = word1.Length;
        int lenWord2 = word2.Length;
        while (index < lenWord1 || index < lenWord2)
        {
            if (index == lenWord1)
            {
                string endString = word2.Substring(lenWord1);
                return res += endString;
            }

            if (index == lenWord2)
            {
                string endString = word1.Substring(lenWord2);
                return res += endString;
            }
            res += word1[index];
            res += word2[index];
            index++;
        }

        return res;
    }
}
