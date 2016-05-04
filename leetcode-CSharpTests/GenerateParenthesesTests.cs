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
    public class GenerateParenthesesTests
    {
        [TestMethod()]
        public void GenerateParenthesisTest()
        {
            Func<int, IList<string>> func = new GenerateParentheses().GenerateParenthesis;
            AreEqual(new[] { "((()))", "(()())", "(())()", "()(())", "()()()" }, func(3));
            AreEqual(new[] { "(((())))", "((()()))", "((())())", "((()))()", "(()(()))", "(()()())", "(()())()", "(())(())", "(())()()", "()((()))", "()(()())", "()(())()", "()()(())", "()()()()" }, func(4));
        }

        public void AreEqual(IList<string> a, IList<string> b)
        {
            try
            {
                Assert.IsTrue(new HashSet<string>(a).SetEquals(new HashSet<string>(b)));
            }
            catch (AssertFailedException e)
            {
                Console.WriteLine("expect is [{0}]", string.Join(", ", a));
                Console.WriteLine("find is [{0}]", string.Join(", ", b));
                throw;
            }
        }
    }
}