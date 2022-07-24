using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{

    //7.	WAP to convert array to List.
    class Class7
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
          
            List<int> l1 = arr.ToList();

            Console.WriteLine(String.Join("\n", l1));

        }


    }
}
