using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test07082022
{
    class LargerSmallerBouncy
    {
        static void Main(string[] args)
        {
            bool isinc = true;
            bool isdesc = true;
            int a = int.Parse(Console.ReadLine());

            int next = a % 10;
            a = a / 10;

            while (a > 0)
            {
                int prev = a % 10;


                if(next < prev)
                {
                    isinc = false;
                }

                 if (next > prev)
                {
                    isdesc = false;
                }
                next = prev;
                a = a / 10;
            }


            if (isinc)
            {
                Console.WriteLine("Increasing");
            }

            else if (isdesc)
            {
                Console.WriteLine("Decreasing");
            }

            else
            {
                Console.WriteLine("Bouncy");
            }

        }
    }
}
