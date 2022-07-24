using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //2.	WAP add elements to List  0th location keep Integer, 1st location String now print each element and display contents.
    class Class2
    {
        static void Main(string[] args)
        {
            List<Object> l1 = new List<object>();

            l1.Add(100);
            l1.Add("Ajinkya");

            foreach (object item in l1)
            {
                Console.WriteLine(item);
            }


        }
    }
}
