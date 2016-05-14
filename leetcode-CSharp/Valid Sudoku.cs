using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[,] board)
        {
            bool[,] rows = new bool[9, 9];
            bool[,] columns = new bool[9, 9];
            bool[,] cells = new bool[9, 9];
            for (int row = 0; row < board.GetLength(0); row++)
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    if (board[row, column] == '.') continue;
                    int n = board[row, column] - '1';
                    int cell = (row / 3) * 3 + column / 3;
                    if (rows[row, n] || columns[column, n] || cells[cell, n])
                        return false;
                    rows[row, n] = columns[column, n] = cells[cell, n] = true;
                }
            return true;
        }
    }
}
