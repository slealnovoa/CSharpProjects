using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    public static class StringExtension
    {
        public static int CountWords(this StringBuilder sb)
        {
            string str = sb.ToString();
            string[] allWords = str.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return allWords.Length;
        }

    }
}
