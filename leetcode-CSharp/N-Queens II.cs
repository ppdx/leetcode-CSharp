using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class N_Queens_II
    {
        public int TotalNQueens(int n)
        {
            if (n == 1) return 1;
            int count = 0;
            int[] board = Enumerable.Repeat(-1, n).ToArray();
            board[0] = 0;
            int row = 1;
            while (board[0] != -1)
            {
                board[row]++;
                for (; board[row] < n; board[row]++)
                {
                    if (CheckBoard(board, row))
                    {
                        row++;
                        break;
                    }
                }
                if (row == n)
                {
                    row--;
                    count++;
                }
                else if (board[row] == n)
                {
                    board[row] = -1;
                    row--;
                }

            }
            return count;
        }

        private bool CheckBoard(int[] board, int row)
        {
            int n = board.Length;
            int col = board[row];
            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i] == j) return false;
            }
            for (int i = row - 1; i >= 0; i--)
            {
                if (board[i] == col) return false;
            }
            for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
            {
                if (board[i] == j) return false;
            }
            return true;
        }
    }
}