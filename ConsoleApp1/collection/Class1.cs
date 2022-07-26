using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class Class1
    {
        static void Main(string[] args)
        {

            string s1 = "aayush";

            char[] arr = s1.ToCharArray();

            Dictionary<char, int> d1 = new Dictionary<char, int>();

            foreach (char ch in arr)
            {

                if (d1.ContainsKey(ch))
                {
                    int currval = d1[ch];
                    d1[ch] = currval + 1;
                    
                }
                else
                {
                    d1.Add(ch, 1);
                }

                foreach (KeyValuePair<Char, int> kv in d1)
                {
                    Console.WriteLine($"{kv.Key}        {kv.Value}");
                }

            }



        }
    }
}
