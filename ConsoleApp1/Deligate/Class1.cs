using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1.Deligate
{
    class Class1
    {
        static bool iseven(int a)
        {
            return a % 2 == 0;
        }


        static void Main(string[] args)
        {
           
            List<int> l1 =new  List<int> () { 23,24,25,26,27,28,29,30 };

            //callback function
            List<int> l3 = l1.FindAll((a) => a%2 == 0);


        }
    }
}
