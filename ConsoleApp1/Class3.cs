﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());

            int  a = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }



            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        
        }
    }
    }

