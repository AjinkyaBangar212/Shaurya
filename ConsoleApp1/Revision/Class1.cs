using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Revision
{
    class Class1
    {

        static void Main(string[] args)
        {
            string nm = "Ajinkya";
            char a = 'x';
            int x = 10;
            float xx = 19.20f;
            double d = 20.50d;
            bool b = true;
            long l = 505050;

            Console.WriteLine($"{nm} {a} {x} {xx} {d} {b} {l}");



            //const keyword 

            const int c = 20;


            Console.WriteLine(c);
            Console.WriteLine();

            //type casting

            //implicit char -> int -> long automatically

            int a1 = 20;

            double dd = a1;

            Console.WriteLine(dd);
            Console.WriteLine(a1);

            char ax = 'A';
            string x1 = Convert.ToString(ax); 

            Console.WriteLine(x1);

            Console.WriteLine();


            float f = 13.70f;

            int ff = (int) f;

            Console.WriteLine(ff);



            int[] arr = new int[5];


            Console.WriteLine("Enter 5 element");
            for (int i = 0; i< arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            int m = arr.Max();

            Console.WriteLine(m);
            Console.WriteLine();


            for (int i = 0; i< arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }




            // array 


            int[] arr1 = new int[3];

            Console.WriteLine("Enter 3 element");


            for(int i = 0; i< arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            int mm = arr1.Max();

            Console.WriteLine(mm);


     


            
        }
    }
}
