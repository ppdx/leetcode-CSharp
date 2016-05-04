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
    public class ImplementStrStrTests
    {
        [TestMethod()]
        public void StrStrTest()
        {
            Action<string,string> t = (s1, s2) => Assert.AreEqual(s1.IndexOf(s2), new ImplementStrStr().StrStr(s1, s2));
            t("", "");
            t("aaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaab");
            t("abc", "bc");
        }
    }
}