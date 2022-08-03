using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Revision
{
    class Class2
    {
        static void Method3(int aa, int yy)
        {
            Console.WriteLine(aa+yy);
        }

        static void method2(int x ,int y)
        {
            Console.WriteLine(x+y);
        }
        static void method1(string x)
        {
            Console.WriteLine(x);
        }

        static void method()
        {
            Console.WriteLine("In Method");
        }
        static void Main(string[] args)
        {
            method();
            method();
            method();


            method1("Ajinkya");

            method2(50,10);

            Method3(20,60);

        }
    }
}
