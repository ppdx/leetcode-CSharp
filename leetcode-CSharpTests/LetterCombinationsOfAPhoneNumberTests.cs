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
    public class LetterCombinationsOfAPhoneNumberTests
    {
        [TestMethod()]
        public void LetterCombinationsTest()
        {
            if (!new HashSet<string>(new[] {"ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"})
                .SetEquals(new HashSet<string>(new LetterCombinationsOfAPhoneNumber()
                    .LetterCombinations("23"))))
                Assert.Fail();
        }
    }
}