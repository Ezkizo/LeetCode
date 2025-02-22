using System.ComponentModel.Design;

namespace pruebasLeetCode;
public class _3_LongestSubstring
{
    public int Solution(string target)
    {
        //int contador;
        //int previousCount = 0;
        //var arr = target.ToCharArray();
        //int iteracion = 0;
        //var previousLongest = string.Empty;
        //var newestLongest = string.Empty;
        //Dictionary<char, int> dict;
        //do
        //{
        //    dict = new Dictionary<char, int>();
        //    contador = 0;
        //    foreach (var item in arr)
        //    {
        //        if (dict.ContainsKey(item))
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            dict.Add(item, 1);
        //            contador++;
        //        }
        //    }

        //    if (previousLongest.Length == 0)
        //    {
        //        foreach (var c in dict)
        //        {
        //            previousLongest += c.Key;
        //        }
        //        previousCount = previousLongest.Length;
        //    }

        //    if (previousCount == 0)
        //        foreach (var c in dict)
        //        {
        //            newestLongest += c.Key;
        //        }

        //    if (iteracion == 0)
        //    {
        //        contador = previousLongest.Length;
        //        iteracion++;
        //    }
        //    else
        //    {
        //        break;
        //    }

        //} while (true);

        //Genera la solución previa a está la que usaba Math.Max, generala completa

        if (string.IsNullOrEmpty(target))
            return 0;

        var tartrim = target.Trim();
        if (string.IsNullOrEmpty(tartrim))
            return 1;
        int result = 0;
        string helper = string.Empty;
        Dictionary<char, int> dict = new();
        List<string> compareList = new();

        foreach (var item in target)
        {
            var xdd = target.IndexOf(item);
            var ddd = target.Split(item);

            if (dict.ContainsKey(item))
            {
                compareList.Add(helper);
                helper = string.Empty;
                helper = item.ToString();
                dict = new Dictionary<char, int>();
                dict.Add(item, 1);
                result = 0;
            }
            else
            {
                dict.Add(item, 1);
                helper += item;
                result++;
            }
        }

        if (helper.Length > 0)
            compareList.Add(helper);

        if (compareList.Count != 0)
        {
            int prev = int.MinValue;
            foreach (var c in compareList)
            {
                if (c.Length > prev)
                {
                    prev = c.Length;
                    result = c.Length;
                }
            }
        }

        return result;
    }
}
