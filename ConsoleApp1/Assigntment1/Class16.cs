using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{
/*
    16.	WAP to show checked exception and use multiple catch block with universal Exception handler.
    */
    
    
    
    class Class16
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter The Number");
                int x = int.Parse(Console.ReadLine());

                int c = x / 0;

            }

            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
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
}
