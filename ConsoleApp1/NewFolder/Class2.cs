using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{


    //overriding 


    class vehical
    {
        public  virtual void car()
        {
            Console.WriteLine("Vehical");
        }
    }

    class BMW : vehical
    {
        public override void car()
        {
            Console.WriteLine("BMW");
        }
    }



    class Class2
    {
        static void Main(string[] args)
        {
            vehical obj = new BMW();
            obj.car();
        }
    }
}
