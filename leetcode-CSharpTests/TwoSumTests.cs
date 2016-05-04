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
    public class TwoSumSolutionTests
    {
        int[][] arg1 = new int[][] 
        {
            new int[] {3, 2, 4 },
            new int[] {-3, 4, 3, 90}
        };

        int[] arg2 = new int[] { 6, 0 };

        int[][] res = new int[][]
        {
            new int[] {1, 2 },
            new int[] {0,2}
        };

        [TestMethod()]
        public void TwoSumTest()
        {
            Assert.IsTrue(arg1.Length == arg2.Length && arg1.Length == res.Length);
            for (int i = 0; i < arg1.Length; i++)
            {
                if (new TwoSumSolution().TwoSum(arg1[i], arg2[i]).SequenceEqual(res[i]))
                    continue;
                Assert.Fail();
            }
        }
    }
}