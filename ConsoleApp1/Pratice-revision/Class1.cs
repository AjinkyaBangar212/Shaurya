using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Pratice_revision
{
    class Class1
    {
        static void Main(string[] args)
        {
            //type casting 

            int i = 10;

            long x = (long) i ;

            Console.WriteLine(x);


            int aa = 10;

            double cc =  aa;

            Console.WriteLine(cc);


            long yy = 10;
            int cv = (int)yy;
            Console.WriteLine(cv);



            float xc = 10.20f;

            long ff =(long) xc;

            long z = 10;
            float d = (float) z;
            Console.WriteLine(d);



            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myInt));   // convert bool to string


            float f = 10.20f;

           string vvv =  Convert.ToString(f);

            Console.WriteLine(vvv);



          



            int ccc = 10;

         string   bbbbb = Convert.ToString(ccc);

            Console.WriteLine(bbbbb);


            int x1 = 10;
            int x2 = 20;

            Console.WriteLine(Math.Min(x1,x2));
            Console.WriteLine(Math.Max(x1,x2));

           Double x3= Math.Sqrt(x1);
            Console.WriteLine(x3);



                  }
    }
}
