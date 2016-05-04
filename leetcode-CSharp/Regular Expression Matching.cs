using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class RegularExpressionMatching
    {
        const int ThisPatten = 0x1;
        const int NextPatten = 0x2;
        public bool IsMatch(string s, string p)
        {
            var table = new int[p.Length, 54];
            int patten = 0;
            for (int i = 0; i < p.Length; i++)
            {
                var d = i < p.Length - 1 && p[i + 1] == '*' ? ThisPatten | NextPatten : NextPatten;
                table[patten, Convert(p[i])] = d;
                if (i < p.Length - 1 && p[i + 1] == '*')
                {
                    table[patten, 53] = 1;
                    i++;
                }
                patten++;
            }

            int maxPatten = patten;

            var current = new HashSet<int>();
            var next = new HashSet<int>();
            current.Add(0);
            for (int i = 0; i < maxPatten && table[i, 53] == 1; i++)
                current.Add(i + 1);
            foreach (char c in s)
            {
                foreach (int pp in current)
                {
                    if (pp == maxPatten) continue;
                    if ((table[pp, Convert(c)] & ThisPatten) != 0 || (table[pp, Convert('.')] & ThisPatten) != 0)
                        next.Add(pp);
                    if ((table[pp, Convert(c)] & NextPatten) != 0 || (table[pp, Convert('.')] & NextPatten) != 0 && pp != maxPatten)
                        next.Add(pp + 1);
                }
                var tmp = new HashSet<int>();
                foreach (int pp in next)
                    for (int i = pp; i < maxPatten && table[i, 53] == 1; i++)
                        tmp.Add(i + 1);
                next.UnionWith(tmp);
                current = next;
                next = new HashSet<int>();
            }
            return current.Contains(maxPatten);
        }

        private int Convert(char c)
        {
            if (c == '.')
            {
                return 52;
            }
            else if (c >= 'a' && c <= 'z')
            {
                return c - 'a';
            }
            return c - 'A' + 26;
        }

        public bool IsMatch2(string s, string p)
        {
            if (p.Length == 1) return s.Length == p.Length && (p == "." || p == s);
            var currentPatten = new bool[p.Length + 1];
            var nextPatten = new bool[p.Length + 1];
            currentPatten[0] = true;
            for (int i = 0; i < p.Length - 1 && p[i + 1] == '*'; i += 2)
            {
                currentPatten[i + 2] = true;
            }
            foreach (char c in s)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    if (!currentPatten[i]) continue;
                    if (c == p[i] || p[i] == '.')
                    {
                        if (i < p.Length - 1 && p[i + 1] == '*')
                        {
                            nextPatten[i] = true;
                        }
                        else
                        {
                            nextPatten[i + 1] = true;
                        }
                    }
                }
                for (int i = 0; i < p.Length; i++)
                    if (nextPatten[i])
                        for (; i < p.Length - 1 && p[i + 1] == '*'; i += 2)
                        {
                            nextPatten[i + 2] = true;
                        }
                var tmp = currentPatten;
                currentPatten = nextPatten;
                nextPatten = tmp;
                for (int i = 0; i < nextPatten.Length; i++)
                {
                    nextPatten[i] = false;
                }
            }
            return currentPatten.Last();
        }
    }
}
