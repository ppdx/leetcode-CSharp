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
    public class GroupAnagramsSolutionTests
    {
        [TestMethod()]
        public void GroupAnagramsTest()
        {
            T(new[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                new[] { new[]{"ate", "eat","tea"},
                    new[]{"nat","tan"},
                    new[]{"bat"}});
        }

        void T(string[] arg1, IList<IList<string>> r)
        {
            Utility.AreSetEqual(r, new GroupAnagramsSolution().GroupAnagrams(arg1),
                new Utility.UnorderdEqualityComparer<string>());
        }
    }
}