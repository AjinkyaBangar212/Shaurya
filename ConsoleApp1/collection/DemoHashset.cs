using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoHashset
    {

        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();

            hs.Add("Ajinkya");
            hs.Add("Prasad");
            hs.Add("Neha");
            hs.Add("Sneha");
            hs.Add("Om");
            hs.Add("Aditya");

            Console.WriteLine("******************************List 1");
            foreach  (string s in hs)
            {
                Console.WriteLine(s);
            }




            HashSet<string> hs2 = new HashSet<string>();

            hs2.Add("Ajinkya");
            hs2.Add("Prasad");
            hs2.Add("Neha");
            hs2.Add("Sneha");
            hs2.Add("Om");
            hs2.Add("Aditya");

            Console.WriteLine("******************************List 2");

            foreach (string s in hs2)
            {
                Console.WriteLine(s);
            }






        }

    }
}
