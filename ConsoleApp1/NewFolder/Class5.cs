using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{

    //abstract 

    abstract class AA
    {
        abstract public void mm();
    }



    class BB : AA
    {
        public override void mm()
        {
            Console.WriteLine("GOT IT ...................");
        }
    }



    class Class5
    {
        static void Main(string[] args)
        {
            BB obj = new BB();
            obj.mm();
        }
    }
}
