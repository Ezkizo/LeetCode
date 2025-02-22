namespace pruebasLeetCode;
public class _20_ValidParentheses
{
    //PENDIENTE
    public bool IsValid(string s)
    {
        var len = s.Length;
        if (len <= 1 || len > 10000)
            return false;

        int parentHelp = 0;
        int key = 0;
        int otherHelp = 0;
        for (int i = 0; i < len; i++)
        {
            var prev = i >= 1 ? s[i - 1] : s[i];

            if (prev.Equals(s[i]) && i > 0)
                return false;

            if ((prev.Equals(')') || prev.Equals('}') || prev.Equals(']')) && i == 0)
                return false;

            if (s[i].Equals(')') || s[i].Equals('}') || s[i].Equals(']'))
            {
                switch (s[i])
                {
                    case '}':
                        if (prev.Equals('(') || prev.Equals('['))
                            return false;
                        break;
                    case ')':
                        if (prev.Equals('{') || prev.Equals('['))
                            return false;
                        break;
                    case ']':
                        if (prev.Equals('(') || prev.Equals('{'))
                            return false;
                        break;
                }
            }

            if (s[i].Equals('('))
            {
                parentHelp++;
                continue;
            }
            else if (s[i].Equals(')'))
            {
                parentHelp++;
                continue;
            }

            if (s[i].Equals('{'))
            {
                otherHelp++;
                continue;
            }
            else if (s[i].Equals('}'))
            {
                otherHelp++;
                continue;
            }

            if (s[i].Equals('['))
            {
                key++;
                continue;
            }
            else if (s[i].Equals(']'))
            {
                key++;
                continue;
            }
        }

        if ((parentHelp % 2 == 0) && (key % 2 == 0) && (otherHelp % 2 == 0))
            return true;
        return false;
    }
}
