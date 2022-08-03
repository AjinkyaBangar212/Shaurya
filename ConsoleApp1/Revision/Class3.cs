using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Revision
{
    class Class3
    {



        static void method4(int x, int y , int z)
        {
            Console.WriteLine(x+y+z);
        }

        static float method1(float x , float y)
        {
            return x + y;
        }
        static int method(int x , int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
          int x = method(10, 10);
            Console.WriteLine(x);


            float cc= method1(10.20f,50.20f);
            Console.WriteLine(cc);



            method4(z : 20 , x : 30 , y : 50);


        }
    }
}
