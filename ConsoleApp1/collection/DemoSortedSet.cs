using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoSortedSet
    {
        static void Main(string[] args)
        {
            SortedSet<int> ss = new SortedSet<int>();

            ss.Add(10);
            ss.Add(20);
            ss.Add(30);
            ss.Add(40);
            ss.Add(50);
            ss.Add(60);
            ss.Add(70);
            ss.Add(80);



            foreach (int  item in ss)
            {
                Console.WriteLine(item);
            }

        }
    }
}
