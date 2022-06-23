using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{

/*    4.	Create interface Cake with a method declared as bake.Create 2 classes
Strawberry, BlackForest both implementing Cake interface.
*/

    interface Icake
    {
        abstract void bake();
    }

    class Strawberry:Icake
    {
        public  void bake() 
        {
            Console.WriteLine("Strawberry is Red");
        }
    }

    class BlackForest:Icake
    {
        public void bake()
        {
            Console.WriteLine("Cake is Sweet");
        }
    }


    class Class4
    {
        static void Main(string[] args)
        {
            BlackForest obj = new BlackForest();
            obj.bake();

           Strawberry objst = new Strawberry();
            objst.bake();

        }
    }
}
