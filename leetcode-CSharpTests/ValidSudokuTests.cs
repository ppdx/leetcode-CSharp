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
    public class ValidSudokuTests
    {
        [TestMethod()]
        public void IsValidSudokuTest()
        {
            Action<string, bool> t = (s, b) => Assert.AreEqual(b, new ValidSudoku().IsValidSudoku(SudokuBuilder(s)));
            t("53..7.... 6..195... .98....6. 8...6...3 4..8.3..1 7...2...6 .6....28. ...419..5 ....8..79", true);

        }

        public char[,] SudokuBuilder(string s)
        {
            var rows = s.Split(' ', '\n', '\t');
            Assert.AreEqual(9, rows.Length);
            var table = new char[9, 9];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    table[i, j] = rows[i][j];
            return table;
        }
    }
}