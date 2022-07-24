using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{

    //4.	WAP of swap two elements in an List
    class Class4
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();

            l1.Add(0);
            l1.Add(200);
            l1.Add(300);

            Console.WriteLine("First Element Before Swaping " + l1[1]);
            Console.WriteLine("Second Element Before Swaping " + l1[2]);

            l1[0] = l1[1];
            l1[1] = l1[2];
            l1[2] = l1[0];


            Console.WriteLine("\n First Element After Swaping " + l1[1]);
            Console.WriteLine("Second Element After Swaping " + l1[2]);



         


        }
    }
}
