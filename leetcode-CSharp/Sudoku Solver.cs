using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class SudokuSolver
    {
        private char[,] board;
        private bool[,] cells;
        private bool[,] columns;
        private bool[,] rows;

        public void SolveSudoku(char[,] board)
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
                    rows[row, n] = columns[column, n] = cells[cell, n] = true;
                }
            this.rows = rows;
            this.columns = columns;
            this.cells = cells;
            this.board = board;
            SolveHelper();
        }

        bool SolveHelper(int row = 0, int column = 0)
        {
            for (; row < 9; row++, column = 0)
                for (; column < 9; column++)
                    if (board[row, column] == '.')
                        goto found;
            found:
            if (row == 9 && column == 0)
                return true;
            for (int n = 0; n < 9; n++)
            {
                int cell = (row / 3) * 3 + column / 3;
                if (!(rows[row, n] || columns[column, n] || cells[cell, n]))
                {
                    rows[row, n] = columns[column, n] = cells[cell, n] = true;
                    if (SolveHelper(row, column + 1))
                    {
                        board[row, column] = (char)(n + '1');
                        return true;
                    }
                    rows[row, n] = columns[column, n] = cells[cell, n] = false;
                }
            }
            return false;
        }
    }
}
