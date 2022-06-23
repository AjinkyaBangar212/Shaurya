using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{
    //14.	WAP to use catch / handle the IndexOutOfRangeException exception
    
    
    

   



    

    class Class14
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3 };
            try
            {
                for (int i = 0; i <= arr.Length; i++)  // <= showing  System.IndexOutOfRangeException
                {
                    Console.WriteLine(arr[i]);
                }
            }

            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine("This Is System.IndexOutOfRangeException Exception Handling ");
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("\n Finally Use For Closing File or Program ");
            }

        }
    }









    class AForeachArray
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];

                Console.WriteLine("Enter 5 Element");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("/////////////////////////////////////");
                foreach (object a in arr)
                {
                    Console.WriteLine(a);
                }
            }

            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Finally Use For Closing File or Program ");
            }
        }
    }

}
