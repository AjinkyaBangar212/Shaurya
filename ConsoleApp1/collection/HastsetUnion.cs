using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class HastsetUnion
    {
        static void Main(string[] args)
        {
            HashSet<string> hs1 = new HashSet<string>() { "A", "BB" ,"CC" ,"ZZ" };
            HashSet<string> hs2 = new HashSet<string>() { "DD" , "BB" , "CC" , "EE" , "FF"};

            hs1.IntersectWith(hs2);
            //           hs1.UnionWith(hs2);
          
            foreach (string s in hs1)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("////////////");

            foreach (string s in hs2)
            {
                Console.WriteLine(s);
            }
        }
    }
}
