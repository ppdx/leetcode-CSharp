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
    public class JumpGameIITests
    {
        [TestMethod()]
        public void JumpTest()
        {
            T(new[] { 2, 3, 1, 1, 4 }, 2);
        }

        void T(int[] a1, int r) =>
            Assert.AreEqual(r, new JumpGameII().Jump(a1));
    }
}