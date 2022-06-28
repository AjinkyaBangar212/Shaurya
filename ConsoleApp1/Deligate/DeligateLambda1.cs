using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{

    public delegate int myde(int a , int b );
    class DeligateLambda1
    {
        static void Main(string[] args)
        {

            myde obj = (a, b) =>
            {
                return a + b;
            };

            Console.WriteLine( obj(8,9));

            //2nd way

            myde obj1 = (a, b) => a * b;
            
            Console.WriteLine(obj1(10, 10));
        
        
        
        }
    }
}
