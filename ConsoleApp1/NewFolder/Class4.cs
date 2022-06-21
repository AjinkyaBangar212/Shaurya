using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{



    //abstraction 

    abstract class O
    {
      abstract public void m();
        
    }


    class P : O
    {
        override public  void m()
        {
            Console.WriteLine("Got It");
        }
    }

    class Class4
    {
        static void Main(string[] args)
        {
            //we will  never create object of abstract class
            //

            P obj = new P();
            obj.m();

        }
    }
}
