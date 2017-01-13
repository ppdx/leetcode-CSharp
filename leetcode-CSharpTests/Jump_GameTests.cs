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
    public class Jump_GameTests
    {
        [TestMethod()]
        public void CanJumpTest()
        {
            Assert.IsTrue(new Jump_Game().CanJump(new[] { 2, 3, 1, 1, 4 }));
            Assert.IsFalse(new Jump_Game().CanJump(new[] { 3, 2, 1, 0, 4 }));
        }
    }
}
