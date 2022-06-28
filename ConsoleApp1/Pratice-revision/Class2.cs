using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Pratice_revision
{
    class Class2
    {
        static void Main(string[] args)
        {

            string str = "abcdefghijklmnopqrstuvwxyz";

            int x = str.Length;

            Console.WriteLine(x);




            Console.WriteLine(str.ToUpper());





            string c = str.ToLower();
            Console.WriteLine(c);


            string a = "abcd ";
            string b = "PQRS";

            Console.WriteLine(a + b);



            string c1 = string.Concat(a, b);

            Console.WriteLine(c1);


            Console.WriteLine(string.Concat(a,b));


            string a3 = "Ajinkya";

            Console.WriteLine(a3[0]);
            Console.WriteLine(a3[6]);

            
           int cccc= a3.IndexOf("n");
            Console.WriteLine(cccc);

            Console.WriteLine(a3.IndexOf("y"));



            Console.WriteLine("***************************");


            string b1 = "Shubhangi Santosh Bangar";  //.Lenghth Count Spapces also so  ans is 24

            int xx = b1.Length;
            Console.WriteLine(xx);

            int z = b1.IndexOf("u");
            Console.WriteLine(z);


            string addall = b1.Substring(z);

            Console.WriteLine(addall);

            Console.WriteLine(  "********************************////////////////////");


            string x4 = "Raghav Juyal Dancer";

            string x5 = x4.Substring(6);

            Console.WriteLine(x5);


            Console.WriteLine("------------------------");


            string str1 = "ThinkQuetion Doing Bias Behave With Student ";

            int inde = str1.IndexOf("D");

            Console.WriteLine(str1.Substring(inde));


            Console.WriteLine("////////////////////");


            string fstr = "Dagadu Ganpat Ghule";

            int ind2 = fstr.IndexOf("G");

            Console.WriteLine(fstr.Substring(ind2));




            //bool


            int x1 = 10;
            int x2=30;
            Console.WriteLine(10<30);

            Console.WriteLine(x1<x2);




        }
    }
}
