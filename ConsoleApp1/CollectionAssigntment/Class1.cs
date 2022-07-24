using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{

    //1.	WAP to add elements to and print content of it where Integer is used. In second List String is used.






    class Class1
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            l1.Add(10);
            l1.Add(20);
            l1.Add(30);
            l1.Add(40);
            l1.Add(50);

            foreach (int x in l1)
            {
                Console.WriteLine($"{x} ");
            }

            List<String> l2 = new List<string>();

            l2.Add("Ajinkya");
            l2.Add("Neha");
            l2.Add("Saket");
            l2.Add("Rushi");
            l2.Add("Ayesha");

            foreach (string x1 in l2)
            {
                Console.WriteLine($"{x1} ");
            }
        }
    }
}
