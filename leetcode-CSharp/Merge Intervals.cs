using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class MergeIntervals
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            if (intervals.Count <= 1) return intervals;
            intervals = intervals.OrderBy(interval => interval.start).ToList();

            var result = new List<Interval>(intervals.Count);
            Interval lastInterval = intervals[0];
            foreach (var interval in intervals.Skip(1))
            {
                int start = interval.start, end = interval.end;
                if (start <= lastInterval.end)
                {
                    lastInterval.end = Math.Max(end, lastInterval.end);
                }
                else
                {
                    result.Add(lastInterval);
                    lastInterval = interval;
                }
            }
            result.Add(lastInterval);
            return result;
        }
    }
}
