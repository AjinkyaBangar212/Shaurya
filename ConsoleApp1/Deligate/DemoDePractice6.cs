using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{

    public delegate int del(int a);
    class DemoDePractice6
    {


        static int m(int a)
        {
            return a;
        }



        static void Main(string[] args)
        {

            del obj = DemoDePractice6.m;

          int a=  obj(5000);
            Console.WriteLine(a);
             
        }
    }
}
