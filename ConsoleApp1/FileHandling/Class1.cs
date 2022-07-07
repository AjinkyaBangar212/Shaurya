using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1.FileHandling
{
    class Class1
    {
        static void Main(string[] args)
        {

            FileStream fr = new FileStream("E://Shaurya.txt", FileMode.Append, FileAccess.Write);
            fr.WriteByte(65);
            fr.WriteByte(65);
            fr.Close();

            FileStream fr2 = new FileStream("E://Shaurya.txt", FileMode.Open, FileAccess.Read);
            Console.WriteLine(fr2.ReadByte());
            Console.WriteLine(fr2.ReadByte());
            Console.WriteLine(fr2.ReadByte());
            Console.WriteLine(fr2.ReadByte());
        }
    }




        class Class2 {

            static void Main(string[] args)
            {
                StreamWriter s1 = new StreamWriter("E://Second.txt" ,true);

                try
                {
                    s1.WriteLine("I am Ajinkya");
                    s1.WriteLine("Now Learning File Handling");
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    s1.Close();
                }
            }


        class Class3
        {
            static void Main(string[] args)
            {

            }
        }





        }
    }

