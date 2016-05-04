using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class RomanToInteger
    {
        private readonly int[] _numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private readonly string[] _romans = "M CM D CD C XC L XL X IX V IV I".Split();
        public int RomanToInt(string s)
        {
            int result = 0;
            for (int i = 0; !string.IsNullOrEmpty(s);)
            {
                if (s.StartsWith(_romans[i]))
                {
                    result += _numbers[i];
                    s = s.Substring(_romans[i].Length);
                }
                else
                {
                    i++;
                }
            }
            return result;
        }
    }
}
