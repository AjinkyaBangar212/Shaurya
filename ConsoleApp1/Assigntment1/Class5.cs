using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{/*5.	 Create interface IceCream with method eat and Juice with method drink,
Create class Mastani which implements both interfaces.*/



    interface IIceCream
    {
        void eat();
        void juice();
        void drink();
    }



    interface Imastani
    {
        void p();
    }


    class Mastani:IIceCream,Imastani
    {
        public void eat()
        {
            Console.WriteLine("You Can Eat MAstani");
        }

        public void juice()
        {
            Console.WriteLine("You Can Treat Mastani As a Juice");
        }
        public void drink()
        {
            Console.WriteLine("You can Drink Mastani");

        }
        public void p()
        {
            Console.WriteLine("Mastani");

        }


    }



    class Class5
    {

        static void Main(string[] args)
        {
            Mastani obj = new Mastani();
            obj.eat();
            obj.juice();
            obj.drink();
            obj.p();

        }

    }
}
