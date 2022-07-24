using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //5.	WAP to replace the second element of an List with the specified element

    class Class5
    {

        static void Main(string[] args)
        {

            List<string> l1 = new List<string>();

            l1.Add("Ajinkya");
            l1.Add("Neha");
            l1.Add("Prasad");
            l1.Add("Shweta");

            Console.WriteLine("List Before Changing Element : ");

            foreach (string x in l1)
                Console.WriteLine(x);


            l1[1] = "Deepti";

            Console.WriteLine("\n List After Changing Element : ");

            foreach (string x in l1)
                Console.WriteLine(x);


        }

    }
}
