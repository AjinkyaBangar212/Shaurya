using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Revision
{

  

    class Class4
    {
      

            string color = "Red";

        
        static void meth()
        {
            Console.WriteLine("1");
        }

        static void meth(int x)
        {
            Console.WriteLine(x);
        }

        static int meth(int x,int y)
        {
            return x + y;
        }


        static void Main(string[] args)
        {
            meth();
            meth(70);
  
            
            Console.WriteLine(meth(50,50));

            Class4 obj = new Class4();

            string a = obj.color;
            Console.WriteLine(a);

         
           
        
        
        }
    }
}
