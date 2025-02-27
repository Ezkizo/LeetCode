using System.Security.Cryptography.X509Certificates;

namespace pruebasLeetCode;
public class _217_ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        //Mi solución
        var hash = new HashSet<int>(nums);
        return (hash.Count != nums.Length);
    }
}
