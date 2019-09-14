using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private Hashtable glossary = new Hashtable();
        private ArrayList lstWords = new ArrayList();

        private void BuildGlossary(Hashtable g)
        {
            StreamReader reader = File.OpenText(@"C:\words.txt");
            string line;
            string[] words;
            char[] delimiter = new char[] { ',' };
            while (reader.Peek() != -1)
            {
                line = reader.ReadLine();
                words = line.Split(delimiter);
                g.Add(words[0], words[1]);
            }
        }

        private void DisplayWords(Hashtable g)
        {
            object[] words = new object[100];
            g.Keys.CopyTo(words, 0);
            for (int i = 0; i <= words.GetUpperBound(0); i++)
                if (!(words[i] == null))
                    lstWords.Add(words[i]);           
        }
    }
}
