using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            var result = new List<int>(row * col);
            int x = 0, y = 0;
            int delteX = 0, delteY = 1;
            int count = 0;
            while (count < row * col)
            {
                result.Add(matrix[x, y]);
                if (delteY == 1 && y == col - x-1)
                {
                    delteX = 1;
                    delteY = 0;
                }
                if (delteX == 1 && x == row - col + y)
                {
                    delteX = 0;
                    delteY = -1;
                }
                if (delteY == -1 && y == row - x-1)
                {
                    delteX = -1;
                    delteY = 0;
                }
                if (delteX == -1 && x == y + 1)
                {
                    delteX = 0;
                    delteY = 1;
                }
                x += delteX;
                y += delteY;
                count++;
            }
            return result;
        }
    }
}
