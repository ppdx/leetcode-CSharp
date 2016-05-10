using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class SubstringWithConcatenationOfAllWords
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            if (words.Length == 0) return new int[] { };
            var all = MakeDict(words);
            var length = words[0].Length;
            var count = words.Length;
            if (s.Length < length * words.Length) return new int[] { };
            var result = new List<int>(s.Length);
            for (int i = 0; i < length; i++)
            {
                var wordsArray = WordsArray(s, i, length);
                for (int j = 0; j <= wordsArray.Count - count; j++)
                {
                    var round = new Dictionary<string, int>(all);
                    for (int k = 0; k < count; k++)
                    {
                        if (!RemoveIfpossible(round, wordsArray[j + k]))
                            goto fail;
                    }
                    result.Add(i + j * length);
                    fail:;
                }
            }
            return result;
        }

        bool RemoveIfpossible(Dictionary<string, int> d, string key)
        {
            if (!d.ContainsKey(key))
                return false;
            if (d[key] == 1) d.Remove(key);
            else d[key]--;
            return true;
        }

        Dictionary<string, int> MakeDict(string[] words)
        {
            var dict = new Dictionary<string, int>(words.Length);
            foreach (var s in words)
            {
                if (dict.ContainsKey(s))
                    dict[s]++;
                else
                    dict[s] = 1;
            }
            return dict;
        }

        IList<string> WordsArray(string s, int offset, int wordLength)
        {
            var wordsList = new List<string>();
            for (; offset <= s.Length - wordLength; offset += wordLength)
            {
                wordsList.Add(s.Substring(offset, wordLength));
            }
            return wordsList;
        }
    }
}
