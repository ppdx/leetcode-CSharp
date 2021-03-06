﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp.Tests
{
    [TestClass()]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            int[] nums = new int[] { 1, 1, 2 };
            Assert.AreEqual(2, new RemoveDuplicatesFromSortedArray().RemoveDuplicates(nums));
            Assert.IsTrue(ArraysEqual(new[] { 1, 2 }, nums));
        }

        static bool ArraysEqual<T>(T[] a1, T[] a2)
        {
            if (ReferenceEquals(a1, a2))
                return true;

            if (a1 == null || a2 == null)
                return false;

            //if (a1.Length != a2.Length)
            //    return false;

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < a1.Length; i++)
            {
                if (!comparer.Equals(a1[i], a2[i])) return false;
            }
            return true;
        }
    }
}