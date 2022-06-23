using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{
/*    6.	Design a class to overload a function volume() as follows:  [2M]
    (i) double volume(double r) – with radius ‘r’ as an argument, returns the volume of sphere using the formula:
v = 4 / 3 × 22 / 7 × r3
(ii)double volume(double h, double r) – with height ‘h’ and radius ‘r’ as the arguments, returns the volume of a cylinder using the formula:
v = 22 / 7 × r2 × h
(iii) double volume(double l, double b, double h) – with length ‘l’, breadth ‘b’ and height ‘h’ as the arguments, returns the volume of a cuboid using the formula:
v = l × b × h
*/

    class Overload
    {
        public double volume(double r)  //method overriding
        {
            double vol = (4 / 3.0) * (22 / 7.0) * r * r * r;
            Console.WriteLine("volume of sphere :" + vol);
            return vol;
          
        }

      public  double volume(double h, double r)//method overriding
        {
            double vol = (22 / 7.0) * r * r * h;
            Console.WriteLine("volume of a cylinder " + vol);
            return vol;
        }

      public  double volume(double l, double b, double h)//method overriding
        {
            double vol = l * b * h;
            Console.WriteLine("volume of a cuboid " + vol);
            return vol;
        }


    }








    class Class6
    {
        static void Main(string[] args)
        {
            Overload obj = new Overload();
            obj.volume(6);
            obj.volume(10,5);
            obj.volume(10, 5 ,15);
        }
    }
}
