using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class GroupAnagramsSolution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var data = new Dictionary<string, List<string>>();
            foreach (string s in strs)
            {
                List<string> value;
                string key = Sort(s);
                if (data.TryGetValue(key, out value))
                    value.Add(s);
                else
                    data[key] = new List<string> { s };
            }
            return data.Values.ToArray();
        }

        private string Sort(string s)
        {
            var c = s.ToCharArray();
            Array.Sort(c);
            return new string(c);
        }
    }
}
