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
    public class SubstringWithConcatenationOfAllWordsTests
    {
        [TestMethod()]
        public void FindSubstringTest()
        {
            Action<string, string[], int[]> t = (s, words, r) => Assert.IsTrue(new SubstringWithConcatenationOfAllWords().FindSubstring(s, words).SequenceEqual(r));
            t("barfoothefoobarman", new[] { "foo", "bar" }, new[] { 0, 9 });
            t("barfoofoobarthefoobarman", new[] { "bar", "foo", "the" }, new[] { 6, 9, 12 });
            t("aaa", new[] { "a", "a" }, new[] { 0, 1 });
            t("wordgoodgoodgoodbestword", new[] { "word", "good", "best", "good" }, new[] { 8 });
        }
    }
}