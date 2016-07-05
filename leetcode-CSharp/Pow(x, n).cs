using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class PowXN
    {
        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;
            if (n == -1) return 1 / x;
            double half = MyPow(x, n / 2);
            if (n % 2 == 0) return half * half;
            return half * half * (n > 0 ? x : 1 / x);
        }
    }
}
