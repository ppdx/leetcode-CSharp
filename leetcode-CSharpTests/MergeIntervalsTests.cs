using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp.Tests
{
    [TestClass()]
    public class MergeIntervalsTests
    {
        [TestMethod()]
        public void MergeTest()
        {
            new[] { new Interval(1, 6), new Interval(8, 10), new Interval(15, 18) }
            .AreSequenceEqual(new MergeIntervals().Merge(
                new[] { new Interval(1, 3), new Interval(2, 6), new Interval(8, 10), new Interval(15, 18) }));
            new[] { new Interval(1, 5) }
                .AreSequenceEqual(new MergeIntervals().Merge(
                    new[] { new Interval(1, 4), new Interval(4, 5) }));
        }
    }
}