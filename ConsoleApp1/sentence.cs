using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sentence
    {
        // find the longest word in the sentence

        string longest = "";

        public void compare(string word)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }

        public void longestWord(string txt)
        {
            string word = "";

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == ' ')
                {
                    compare(word);
                    word = "";
                } else
                {
                    word = word + txt.Substring(i, 1);
                }
            }
            compare(word);
            Console.WriteLine("Longest word = "+ longest);
        }
    }
}
