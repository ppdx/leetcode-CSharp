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
    public class N_Queens_IITests
    {
        [TestMethod()]
        public void TotalNQueensTest()
        {
            Assert.AreEqual(1, new N_Queens_II().TotalNQueens(1), "arg: 1");
            Assert.AreEqual(2, new N_Queens_II().TotalNQueens(4), "arg: 4");
        }
    }
}