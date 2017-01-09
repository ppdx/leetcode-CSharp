using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetcode_CSharp.Tests;

namespace leetcode_CSharp.Tests
{
    [TestClass()]
    public class NQueensTests
    {
        [TestMethod()]
        public void SolveNQueensTest()
        {
            var result = new NQueens().SolveNQueens(4);
            var resultSet = new HashSet<string>();
            foreach (var item in result)
            {
                resultSet.Add(string.Join(" ", item));
            }
            var answer = new HashSet<string> { ".Q.. ...Q Q... ..Q.", "..Q. Q... ...Q .Q.." };
            Assert.IsTrue(resultSet.SetEquals(answer));
        }
    }
}