using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    public class IPAddresses : DictionaryBase
    {
        public IPAddresses()
        {

        }

        public IPAddresses(string filePath)
        {
            string line;
            string[] words;
            StreamReader streamReader = File.OpenText(filePath);
            while (streamReader.Peek() != -1)
            {
                line = streamReader.ReadLine();
                words = line.Split(',');
                InnerHashtable.Add(words[0], words[1]);
            }
            streamReader.Close();
        }

        public void Add(string name, string ip)
        {
            InnerHashtable.Add(name, ip);
        }

        public void Remove(string name)
        {
            InnerHashtable.Remove(name);
        }

        public string Item(string name)
        {
            return InnerHashtable[name].ToString();
        }
    }
}
