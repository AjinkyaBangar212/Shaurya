using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ExceptionHandling
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {



               // Nullable<int> i = null;     you can assign null value using this concept 
               // or you can assign like this    int ? i = null;   
                Console.WriteLine("Enter 2 Number : ");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Division is {n1/n2}");

                Console.WriteLine("try ends");

             
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (SystemException e)   //universal Exception
            {
                Console.WriteLine(e.Message);
            }



            int x= 0;

            for (int i = 1; i<=5; i++)
            {
                x = i * 2;
                Console.WriteLine(x);
            }




        }
    }
}
