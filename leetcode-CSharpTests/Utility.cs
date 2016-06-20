﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp.Tests
{
    static class Utility
    {
        public static void AreSequenceEqual<T>(this IEnumerable<T> excepted, IEnumerable<T> actual)
        {
            if (excepted.SequenceEqual(actual))
                return;
            throw new AssertFailedException(
                string.Format("Assert sequence equal failed. Excepted [{0}] Actual [{1}]",
                string.Join(", ", excepted), string.Join(", ", actual)));
        }

        public static void AreSetEqual<T>(this IEnumerable<T> excepted, IEnumerable<T> actual,
            IEqualityComparer<T> cmp)
        {
            var set1 = new HashSet<T>(excepted, cmp);
            var set2 = new HashSet<T>(actual, cmp);
            if (!set1.SetEquals(actual))
            {
                throw new AssertFailedException(
                    string.Format("Assert set equal failed. Excepted [{0}] Actual [{1}]",
                    string.Join(", ", excepted), string.Join(", ", actual)));
            }
        }

        public static void AreSetEqual<T>(this IEnumerable<IList<T>> excepted, IEnumerable<IList<T>> actual)
        {
            var set1 = new HashSet<IList<T>>(excepted, new ListEqualityComparer<T>());
            var set2 = new HashSet<IList<T>>(actual, new ListEqualityComparer<T>());
            if (!set1.SetEquals(actual))
            {
                throw new AssertFailedException(
                    string.Format("Assert set equal failed. Excepted [{0}] Actual [{1}]",
                    string.Join(", ", excepted), string.Join(", ", actual)));
            }
        }
        public class ListEqualityComparer<T> : IEqualityComparer<IList<T>>
        {
            public bool Equals(IList<T> x, IList<T> y)
            {
                return x.SequenceEqual(y);
            }

            public int GetHashCode(IList<T> obj)
            {
                return (int)obj.Select(x => (uint)x.GetHashCode())
                               .Aggregate((u1, u2) => (u1 << 7 | u1 >> 25) ^ u2);
            }
        }

        public class ListComparer<T> : IComparer<IList<T>> where T : IComparable<T>
        {
            public int Compare(IList<T> l1, IList<T> l2)
            {
                int len = Math.Min(l1.Count, l2.Count);
                for (int i = 0; i < len; i++)
                {
                    int cmp = l1[i].CompareTo(l2[i]);
                    if (cmp != 0) return cmp;
                }
                return l1.Count - l2.Count;
            }
        }

        public static IList<IList<T>> Sort<T>(this IList<IList<T>> llt, IComparer<IList<T>> cmp) where T : IComparable<T>
        {
            if (llt is List<IList<T>>)
            {
                (llt as List<IList<T>>).Sort(cmp);
            }
            else if (llt is IList<T>[])
            {
                Array.Sort(llt as IList<T>[], cmp);
            }
            else
            {
                llt.OrderBy(e => e, cmp);
            }
            return llt;
        }
        public static IList<IList<T>> Sort<T>(this IList<IList<T>> llt) where T : IComparable<T>
        {
            return llt.Sort(new ListComparer<T>());
        }


    }
}
