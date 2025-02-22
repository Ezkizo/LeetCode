using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
namespace pruebasLeetCode;
public class _14_LongestCommonPrefix
{
    //Write a function to find the longest common prefix string amongst an array of strings.
    //If there is no common prefix, return an empty string "".
    //Example 1:

    //Input: strs = ["flower", "flow", "flight"]
    //Output: "fl"
    //Example 2:

    //Input: strs = ["dog", "racecar", "car"]
    //Output: ""
    //Explanation: There is no common prefix among the input strings.

    //Constraints:
    //1 <= strs.length <= 200
    //0 <= strs[i].length <= 200
    //strs[i] consists of only lowercase English letters if it is non-empty.
    public string LongestCommonPrefix(string[] strs)
    {

        var len = strs.Length;
        if (len is 1)
            return strs[0];
        if (len > 200 || len is 0)
            return "";
        if (strs[0].Length is 0 || strs[0].Length > 200)
            return "";

        int minimo = int.MaxValue, index = 0, contador = 0;
        string common = string.Empty;
        bool help = false;
        //Verificar primero el tamaño minimo del array
        foreach (var cadena in strs)
        {
            if (cadena.Length < minimo)
            {
                minimo = cadena.Length - 1;
            }
        }

        while (contador < minimo)
        {
            help = false;
            for (int i = 1; i < len; i++)
            {
                help = strs[0][contador].Equals(strs[i][contador]);
                if (!help)
                    return common;
                if (help && i + 1 >= len)
                {
                    common += strs[0][index];
                    contador++;
                    index++;
                }
            }
        }

        return common;
        //Errores o no óptimas
        /*int contador = 0, index = 0;
        string common = string.Empty;

        while (true)
        {
            if (index + 1 == len)
                return common;

            if (VerifyEquals(strs[index][contador], strs[index + 1][contador] ?? null))
            {
                common += strs[index][contador];
                contador++;
                continue;
            }
            common = "";
            break;
        }
        return common;

        for (int i = 0; i < len; i++)
        {
            while (true)
            {
                var nextLen = strs[i + 1].Length;
                if (contador + 1 < nextLen && strs[i][contador].Equals(strs[i + 1][contador]))
                {
                    common += strs[i][contador];
                    contador++;
                    continue;
                }
                else if ()
                {
                    continue;
                }
                break;
            }
        }

        while (true)
        {
            if (strs[i][contador].Equals(strs[i + 1][contador]))
            {
                contador++;
                common += strs[i][contador];
                continue;
            }
            else
            {
                contador++;
                continue;
            }
        }
        */
    }
}
