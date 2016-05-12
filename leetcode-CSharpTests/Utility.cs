using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp.Tests
{
    static class Utility
    {
        public static void AreSequenceEqual<T>(IEnumerable<T> excepted, IEnumerable<T> actual)
        {
            if (excepted.SequenceEqual(actual))
                return;
            throw new AssertFailedException(
                string.Format("Assert sequence equal failed. Excepted [{0}] Actual [{1}]",
                string.Join(", ", excepted), string.Join(", ", actual)));
        }
    }
}
