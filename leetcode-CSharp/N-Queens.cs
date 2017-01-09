using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class NQueens
    {
        private string[] lines;
        public IList<IList<string>> SolveNQueens(int n)
        {
            if (n == 1) return new List<IList<string>> { new[] { "Q" } };
            lines = new string[n];
            for (int i = 0; i < n; i++)
            {
                lines[i] = new StringBuilder(n).Append('.', i).Append('Q').Append('.', n - i - 1).ToString();
            }
            List<IList<string>> result = new List<IList<string>>();
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
                    result.Add(ToStringArray(board));
                }
                else if (board[row] == n)
                {
                    board[row] = -1;
                    row--;
                }

            }
            return result;
        }

        private IList<string> ToStringArray(int[] board)
        {
            return board.Select(i => lines[i]).ToArray();
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
