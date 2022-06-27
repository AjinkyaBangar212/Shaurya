using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1.Assigntment25062022
{

//    6.	Write a program to get a set of keys contained in HashTable and print whole HashTable using for each loop.



    class Class6
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("1", "Pune");
            ht.Add("2", "Mumbai");
            ht.Add("3", "Nagpur");


            ICollection x = ht.Keys;

            foreach (string str in x)
                Console.WriteLine(str + ": " + ht[str]);
        }
    }
}
