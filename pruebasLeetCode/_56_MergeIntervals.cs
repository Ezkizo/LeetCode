namespace pruebasLeetCode;
public class _56_MergeIntervals
{
    public int[][] Merge(int[][] intervals)
    {
        int n = intervals.Length;
        if (n == 1)
        {
            return intervals;
        }
        List<int[]> res = new();
        var start = intervals[0][0];
        var end = intervals[0][1];
        for (int i = 1; i < n; i++)
        {
            var startNext = intervals[i][0];
            var endNext = intervals[i][1];
            //var min = Math.Min(start, startNext);
            //var max = Math.Max(end, endNext);

            //if (start > startNext)
            //{

            //}



            if (start >= startNext || end <= endNext)
            {
                if (res.Count == 0)
                {
                    res.Add([(start <= startNext) ? start : startNext, (end <= endNext) ? endNext : end]);
                    start = startNext;
                    end = endNext;
                    continue;
                }

                res.Add([(start >= startNext) ? start : startNext, (end <= endNext) ? endNext : end]);
                start = startNext;
                end = endNext;
                continue;
            }
            if (res.Count == 0)
                res.Add([start, end]);
            res.Add([startNext, endNext]);
            start = startNext;
            end = endNext;
        }
        return res.ToArray();
    }
}
