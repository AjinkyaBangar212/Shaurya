using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{

    class RedymadeDeligate
    {
        static int add(int a , float b , long m )
        {
            Console.WriteLine("Add = " + (a+b));
            return (int) (a+b);
        }

        static void greet(string str)
        {
            Console.WriteLine($"Good Morning {str}");
        }

        static bool EV(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }



        static void Main(string[] args)
        {

            Func<int, float, long ,int> f1 = add;
            int ans = f1(10,3.4f,90L);

            Console.WriteLine(ans);
            

            Action<string> f2 = greet;
            f2("Ajinkya");


            Predicate<int> f3 = EV;
            Console.WriteLine(f3(10));


            



        }
    }
}
