using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class LetterCombinationsOfAPhoneNumber
    {
        private readonly string[] _data =
        {null, null, "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0) return new List<string>();
            var digit = digits.Select(c => c - '0').ToArray();
            int len = digits.Length;
            var indexes = new int[len];
            var maxes = digit.Select(c => _data[c].Length - 1).ToArray();
            var result = new List<string>();

        next:
            var builder = new StringBuilder(len);
            for (int i = 0; i < len; i++)
            {
                builder.Append(_data[digit[i]][indexes[i]]);
            }
            result.Add(builder.ToString());
            for (int i = 0; i < len; i++)
            {
                if (indexes[i] != maxes[i])
                {
                    indexes[i]++;
                    goto next;
                }
                indexes[i] = 0;
            }
            return result;
        }
    }
}
