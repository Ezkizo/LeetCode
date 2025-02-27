namespace pruebasLeetCode;
public class _771_JewelsAndStones
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        //HashSet Time complexity O(1)
        var jewelSet = new HashSet<char>(jewels);
        int count = 0;

        foreach (char stone in stones)
        {
            if (jewelSet.Contains(stone))
            {
                count++;
            }
        }
        return count;

        //var count = 0;
        //for (int i = count; i < stones.Length; i++)
        //{
        //    if (jewels.Contains(stones[i]))
        //    {
        //        count++;
        //    }
        //}
        //return count;

        int res = 0;
        var dictionary = new Dictionary<char, int>();
        foreach (char ch in jewels)
        {
            if (dictionary.ContainsKey(ch))
                continue;
            dictionary.Add(ch, 1);
        }

        foreach (char st in stones)
        {
            if (dictionary.ContainsKey(st))
            {
                res++;
            }
        }
        return res;
    }
}
