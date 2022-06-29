using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{
 /*   Func, Action and Predicate are generic inbuilt delegates present in System namespace.

All three can be used with method, anonymous method and lambda expression.

Func can contains 0 to 16 input parameters and must have one return type.

Action can contain 1 to 16 input parameters and does not have any return type.

Predicate delegate should satisfy some criteria of method and must have one input parameter and one Boolean return type either true or false.

Input parameters of custom delegates is fixed but Func and Actions input parameter is variable from 0 to 16 and 1 to 16 respectively.


*/


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
