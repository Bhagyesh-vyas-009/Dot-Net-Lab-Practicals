using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class LongestWord
    {
        public  string FindLongestWord(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return string.Empty;
            }
            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = string.Empty;
            int maxLength = 0;

            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {
                    longestWord = word;
                    maxLength = word.Length;
                }
            }
            return longestWord;
        }
    }
}
