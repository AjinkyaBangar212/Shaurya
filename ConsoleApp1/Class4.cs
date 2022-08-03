using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class4
    {
        static void Main(string[] args)
        {
            bool isPrime = true;


            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 15; i++)
            {
                for (int j = 2; j <= 15; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
        }
    }
}
