using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class RotateImage
    {
        public void Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            Func<int, int> x2i, y2j;
            int half = n / 2;
            if (n % 2 == 0)
            {
                x2i = x => x > 0 ? x + half - 1 : x + half;
                y2j = y => y < 0 ? half - 1 - y : half - y;
            }
            else
            {
                x2i = x => x + half;
                y2j = y => half - y;
            }

            for (int x = 1 - (n % 2); x <= half; x++)
                for (int y = 1; y <= half; y++)
                {
                    int tmp = matrix[y2j(y), x2i(x)];
                    matrix[y2j(y), x2i(x)] = matrix[y2j(x), x2i(-y)];
                    matrix[y2j(x), x2i(-y)] = matrix[y2j(-y), x2i(-x)];
                    matrix[y2j(-y), x2i(-x)] = matrix[y2j(-x), x2i(y)];
                    matrix[y2j(-x), x2i(y)] = tmp;
                }
        }
    }
}
