using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{

    class a2
    {
        public virtual  void m()
        {
            Console.WriteLine("a2");
        }
    }


    class b2 : a2
    {
        public override void m()
        {
            Console.WriteLine("b2");
        }
    }




    class Class3
    {
        static void Main(string[] args)
        {
            a2 obj = new b2();
            obj.m();
        }
    }
}
