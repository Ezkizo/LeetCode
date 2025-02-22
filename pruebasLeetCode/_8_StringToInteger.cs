using System.Text.RegularExpressions;

namespace pruebasLeetCode;
public class _8_StringToInteger
{
    public int StringToInteger(string s)
    {
        //int res = 0;
        //string pattern = @"[^0-9+-]";
        //var splitNonInteger = Regex.Split(s, pattern);
        //if (splitNonInteger.Length > 0)
        //{
        //    int start = 0;
        //    string value = string.Empty;
        //    foreach (char c in splitNonInteger[0])
        //    {
        //        if ((c.Equals('+') || c.Equals('-')) && start == 0)
        //        {
        //            if (c.Equals('+')) start++;
        //            if (c.Equals('-')) start--;
        //        }
        //        else
        //        {
        //            start = (start != 0) ? start : 1;
        //            value += c;
        //        }
        //    }
        //    var success = int.TryParse(value, out res);
        //    if (success)
        //        return res * start;
        //    else
        //        return 0;
        //}
        //else
        //    return 0;


        int res = 0;
        string pattern = @"[^0-9+-]";
        var splitNonInteger = Regex.Split(s, pattern);
        if (splitNonInteger.Length > 0)
        {
            int start = 0;
            string value = string.Empty;
            int starting = 0;
            foreach (char c in splitNonInteger[0])
            {
                if ((c.Equals('+') || c.Equals('-')) && start == 0)
                {
                    if (c.Equals('+')) start++;
                    if (c.Equals('-')) start--;
                    continue;
                }
                starting = (c.Equals('0') && starting == 0) ? 0 : ++starting;
                if (starting == 0) continue;
                start = (start != 0) ? start : 1;
                value += c;
            }
            var success = int.TryParse(value, out res);
            if (success)
                return res * start;
            else if (!success && value.Length == 0)
            {
                if (start > 0)
                    return int.MaxValue;
                return int.MinValue;
            }
            else
            {
                return 0;
            }
        }
        else
            return 0;
    }
}
