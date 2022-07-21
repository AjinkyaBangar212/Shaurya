using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ExceptionHandling
{



    class Class2
    {
        static void m1(int x , int y)
        {
            Console.WriteLine("M1 start");

            Console.WriteLine(x/y);

            Console.WriteLine("M1 end");

        }

        static void m2(int x , int y)
        {
            Console.WriteLine("M2 Start");

            m1(x,y);

            Console.WriteLine(" M2 End");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main String");
            try
            {
                m2(10,0);
            }

            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Finally Block");
            }






            Console.WriteLine("Back to Main");

            for(int i =1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


           
           
        }
    }
}
