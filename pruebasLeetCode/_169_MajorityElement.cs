namespace pruebasLeetCode;
public class _169_MajorityElement
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> cont = new();
        int res = 0, max = int.MinValue;

        foreach (var num in nums)
        {
            if (cont.ContainsKey(num))
            {
                cont[num]++;
                continue;
            }
            cont.Add(num, 1);
        }
        foreach (var num in cont.Keys)
        {
            if (cont[num] > max)
            {
                max = cont[num];
                res = num;
            }
        }
        return res;
    }
}
