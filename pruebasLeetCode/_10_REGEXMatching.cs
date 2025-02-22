using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasLeetCode;
public class _10_REGEXMatching
{
    public bool IsMatch(string s, string p)
    {
        var orderCompare = p.ToCharArray();
        var orderLen = orderCompare.Length;
        var toCompareChars = s.ToCharArray();
        var compareLen = toCompareChars.Length;
        List<char> anyOrMore = new List<char>();
        char prevChar;
        //'.' //It means any character allowed
        //'*' //It means one more of previous character
        // .* //It means current position of s is equal to current position of p

        int index = 0;
        while (orderLen > 0)
        {
            if (orderLen > 0 && compareLen > 0)
            {
                orderLen--;
                compareLen--;
                if (orderCompare[index].Equals('*'))


                prevChar = orderCompare[index];
                if (orderCompare[index].Equals(toCompareChars[index]))
                {
                    index++;
                    continue;
                }
                else
                    return false;
            }
        }
        if (orderLen == 0 && compareLen == 0)
            return true;
        else
            return false;
    }
}
