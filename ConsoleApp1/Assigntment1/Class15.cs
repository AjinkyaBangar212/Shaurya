using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{
    /*15.	WAP to catch multiple exceptions. i.e IndexOutOfRangeException, NullReferenceException
    and DivideByZeroException.
*/


    class Class15
    {


        static void Main(string[] args)
        {

            int[] arr = { 1,2,3,4,5};

            int a = 10;
            int b = 0;
            
            try
            {
                for (int i = 0; i <= arr.Length; i++) //<=     IndexOutOfRangeException
                {
                    Console.WriteLine(arr[i]);
                }
                

            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }





            try
            {
                Console.WriteLine(a / b);  // DivideByZeroException
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }



            finally
            {
                Console.WriteLine("\n Finally Use For Closing File or Program ");
            }
                
        }




    }
}
