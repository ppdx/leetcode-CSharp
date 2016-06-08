using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class MultiplyStrings
    {
        public string Multiply(string num1, string num2)
        {
            if (string.IsNullOrWhiteSpace(num1) || string.IsNullOrWhiteSpace(num2)
                || num1 == "0" || num2 == "0")
                return "0";
            var a = num1.Select(c => c - '0').Reverse().ToList();
            var b = num2.Select(c => c - '0').Reverse().ToList();
            var result = new int[a.Count + b.Count + 10];

            for (int i = 0; i < a.Count; i++)
                for (int j = 0; j < b.Count; j++)
                {
                    int x = i + j;
                    result[x] +=
                        a[i] *
                        b[j];
                    while (result[x] > 9)
                    {
                        result[x + 1] += result[x] / 10;
                        result[x] %= 10;
                        x++;
                    }
                }
            return string.Join("",
                result.Select(i => (char)(i + '0')).Reverse().SkipWhile(c => c == '0'));
        }
    }
}
