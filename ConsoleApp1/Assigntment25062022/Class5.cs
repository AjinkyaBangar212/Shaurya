using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp1.Assigntment25062022
{
    /*5.	Write a program to get the value of a specified key in a HashTable
 and also update the value for given key.
*/

    class Class5
    {
        static void Main(string[] args)
        {


            Hashtable ht = new Hashtable();

            ht.Add("1","Pune");
            ht.Add("2","Mumbai");
            ht.Add("3","Nagpur");
         

            ICollection x = ht.Keys;

            foreach (string str in x)
                Console.WriteLine(str + ": " + ht[str]);

            ht["2"] = "Nashik";
           


            Console.WriteLine("Updated Values:");
            foreach (string str in x)
                Console.WriteLine(str + ": " + ht[str]);

        }


    }
    }
