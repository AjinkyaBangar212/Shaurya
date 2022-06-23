using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{

    //9.	WAP to find Area of Square, Rectangle, and Circle using Method Overloading

    class OK
    {
        long Area;
        long Side;
        Double Circle;

        public void MYM(long Side)
        {
            Area = Side * Side;
            Console.WriteLine($"Area of Square {Area}");
        }


        public void MYM(long Length,long Breadth)
        {
            Area = Length * Breadth;
            Console.WriteLine($"Area of Rectangle {Area}");
        }

        public void MYM(double Radious)
        {
            Circle = 3.14 * Radious * Radious;
            Console.WriteLine($"Area of Circle is {Circle}");
        }



    }





    class Class9
    {
        static void Main(string[] args)
        {
            OK obj = new OK();
            obj.MYM(12);
            obj.MYM(10,11);
            obj.MYM(15.3);

        }
    }
}
