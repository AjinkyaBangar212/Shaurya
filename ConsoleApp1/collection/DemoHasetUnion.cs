using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoHasetUnion
    {
        static void Main(string[] args)
        {

            HashSet<int> h = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9,30 } ;


            HashSet<int> h2 = new HashSet<int>() { 5 , 6 ,7 ,8, 9,10 ,15 ,16, 17 };

            //   h2.IntersectWith(h);
            //  h.IntersectWith(h2);

            //  h2.UnionWith(h);

            h.UnionWith(h2);


            foreach (int i in h)
            {
                Console.WriteLine(i);
            }



        }
    }
}
