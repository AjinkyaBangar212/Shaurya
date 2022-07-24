using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //3.	WAP to create a new List, add some colors (string) and print the collection.
    class Class3
    {
        static void Main(string[] args)
        {
            List<String> l1 = new List<string>();

            l1.Add("Saffron");
            l1.Add("Green");
            l1.Add("Yellow");
            l1.Add("Blue");
            l1.Add("Red");

            foreach (string item in l1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
