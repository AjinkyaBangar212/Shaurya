using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ACollections.Date23062022
{
    

        class mystored:IComparer<StringBuilder>
        {
            public int Compare(StringBuilder s1 , StringBuilder s2)
            {
                return s1.ToString().CompareTo(s2.ToString());
            }
        }

    class Class2
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> L = new SortedList<StringBuilder,int> (new mystored());


            L.Add(new StringBuilder("Ajin") , 10);
            L.Add(new StringBuilder("RRR"), 110);
            L.Add(new StringBuilder("BBB"), 12);


            foreach (KeyValuePair<StringBuilder,int>     x    in    L )
            {
                Console.WriteLine(x.Key + "   " + x.Value);
            }


        }
    }
}
