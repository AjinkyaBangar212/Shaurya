using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{
/*    2.	A Pen contains variables Refill r, int capLength and String brand.
   Refill has variables inkColor, length and Nib(tip).
	 Nib has variables materialType and width.
    Create a Java class structure for above.
Write a main method which sets values in all the variables
using setter methods and prints all the variables using getter methods.
*/
   class Nib
    {
        string tip;
        string materialType;
        int width;

        public string Tip { get => tip; set => tip = value; }
        public string MaterialType { get => materialType; set => materialType = value; }
        public int Width { get => width; set => width = value; }

       
    }


    class Refill
    {
        string inkColor;
        int length;
        Nib tip;

        public string InkColor { get => inkColor; set => inkColor = value; }
        public int Length { get => length; set => length = value; }
        internal Nib Tip { get => tip; set => tip = value; }

        
    }


    class Pen
    {
        
        int capLength;
        String brand;
        Refill r;

        public int CapLength { get => capLength; set => capLength = value; }
        public string Brand { get => brand; set => brand = value; }
        internal Refill R { get => r; set => r = value; }

       


    }





    class Class2
    {
        static void Main(string[] args)
        {

            Pen obj = new Pen();

            obj.CapLength = 10;
            obj.Brand = "Rorito";

            obj.R = new Refill();
            obj.R.InkColor = "Black";
            obj.R.Length = 5;

            obj.R.Tip = new Nib();
            obj.R.Tip.Tip = "Metal";
            obj.R.Tip.MaterialType = "Metal";
            obj.R.Tip.Width = 10;

            Console.WriteLine($"pen Cap = {obj.CapLength} brand {obj.Brand} InkColor {obj.R.InkColor} Length ={obj.R.Length} Tip = {obj.R.Tip.Tip} Material {obj.R.Tip.MaterialType} width {obj.R.Tip.Width}");

           

        }
    }
}
