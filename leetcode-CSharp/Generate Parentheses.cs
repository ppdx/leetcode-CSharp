using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class GenerateParentheses
    {
        private static readonly List<IList<string>> Table = new List<IList<string>>(1000)
        {
            new string[] {},
            new[] {"()"},
            new[] {"(())", "()()"},
            new[] {"((()))", "(()())", "(())()", "()(())", "()()()"},
            new[]
            {
                "(((())))", "((()()))", "((())())", "((()))()", "(()(()))", "(()()())", "(()())()", "(())(())",
                "(())()()", "()((()))", "()(()())", "()(())()", "()()(())", "()()()()"
            },
            null, null, null, null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, null, null,
        };

        public IList<string> GenerateParenthesis(int n)
        {
            return Get(n);
        }

        public IList<string> Helper(int n)
        {
            var result = new HashSet<string>();
            for (int i = 1; i <= n / 2; i++)
            {
                foreach (string s in Get(i))
                {
                    foreach (string s1 in Get(n - i))
                    {
                        result.Add(s + s1);
                        result.Add(s1 + s);
                    }
                }
            }
            foreach (string s in Get(n - 1))
            {
                result.Add("(" + s + ")");
            }
            return result.ToArray();
        }

        private IList<string> Get(int i)
        {
            return Table[i] ?? (Table[i] = Helper(i));
        }
    }
}
