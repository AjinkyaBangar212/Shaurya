using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1.Assigntment25062022
{
    class Class7
    {
        static void Main(string[] args)
        {
            //  7.Create a HashTable  where key is integers 1 to 10 and string is number in Words.Remove entry for which number is divisible by 3.


            Hashtable ht = new Hashtable();

            ht.Add(1,"One");
            ht.Add(2,"Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, "Five");
            ht.Add(6, "Six");
            ht.Add(7, "Seven");
            ht.Add(8, "Eight");
            ht.Add(9, "Nine");
            ht.Add(10, "Ten");


            
                foreach (DictionaryEntry entry in ht)
                {

                int x = (int) entry.Key ;
             
                if (x % 3 != 0)
                {
                   

                     Console.WriteLine(entry.Key + ":" + entry.Value);
           
                }
               // Console.WriteLine(entry.Key + ":" + entry.Value);

            }

            }





        }
    }
