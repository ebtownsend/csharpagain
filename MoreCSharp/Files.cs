using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MoreCSharp
{
    class Files
    {
        string file = "C:\\data.txt";

        public void readFile(string f)
        {
            string msg = File.ReadAllText(f);
            Console.WriteLine(msg);
        }

        public void writeFile(string text)
        {
            File.WriteAllText(file, text);
        }

        public void appendFile(string text)
        {
            File.AppendAllText(file, text);
        }

        public void remove(string x)
        {
            string startText = File.ReadAllText(file);
            string newText = "";

            for (int i = 0; i < startText.Length; i++)
            {
                if (startText.Substring(i, 1) != x)
                {
                    newText += startText.Substring(i, 1);
                }
            }

            File.WriteAllText("C:\\data2.txt", newText);
        }

        public void findAndReplace(string find, string replace)
        {
            string startText = File.ReadAllText(file);
            string newText = "";

            for (int i = 0; i < startText.Length; i++)
            {
                if (startText.Substring(i, 1) == find)
                {
                    newText += replace;
                } else
                {
                    newText += startText.Substring(i, 1);
                }
            }
            File.WriteAllText("C:\\data3.txt", newText);
        }

    }
}
