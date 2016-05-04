using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            StringBuilder[] data = new StringBuilder[numRows];
            for (int i = 0; i < data.Length; i++)
                data[i] = new StringBuilder();

            int step = 1;
            int row = 0;
            foreach (char c in s)
            {
                data[row].Append(c);
                row += step;
                if (row == 0 || row == numRows - 1) step = -step;
            }
            return data.Aggregate((sb1, sb2) => sb1.Append(sb2.ToString())).ToString();
        }
    }
}
