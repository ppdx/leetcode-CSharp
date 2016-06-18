using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class WildcardMatching
    {
        public bool IsMatch(string s, string p)
        {
            p = SimplifyPatten(p);
            var state = new int[p.Length + 1];
            var next = new int[p.Length + 1];
            AddState(state, 0);
            for (int i = 0; i < p.Length && p[i] == '*'; i++)
                AddState(state, i + 1);
            foreach (char c in s)
            {
                foreach (int i in EnumState(state))
                {
                    if (i == p.Length) continue;
                    if (p[i] == '*')
                        AddState(next, i);
                    if (p[i] == '?' || p[i] == c || p[i] == '*')
                    {
                        AddState(next, i + 1);
                        if (i < p.Length - 1 && p[i + 1] == '*')
                            AddState(next, i + 2);
                    }
                }
                var tmp = state;
                state = next;
                next = tmp;
                ClearState(next);
            }
            return state[p.Length] == 1 ||
                p.Length > 0 && p[p.Length - 1] == '*' && state[p.Length - 1] == 1;
        }

        private string SimplifyPatten(string p)
        {
            var sb = new StringBuilder(p.Length);
            for (int i = 0; i < p.Length;)
            {
                sb.Append(p[i]);
                if (p[i++] == '*')
                    while (i < p.Length && p[i] == '*')
                        i++;
            }
            return sb.ToString();
        }

        private void ClearState(int[] next)
        {
            Array.Clear(next, 0, next.Length);
        }

        private void AddState(int[] state, int v)
        {
            state[v] = 1;
        }

        private IEnumerable<int> EnumState(int[] state)
        {
            for (int i = 0; i < state.Length; i++)
            {
                if (state[i] == 1) yield return i;
            }
        }
    }
}
