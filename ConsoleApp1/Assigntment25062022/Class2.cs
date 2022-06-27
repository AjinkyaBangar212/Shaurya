using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace ConsoleApp1.Assigntment25062022
{
    class Class2
    {
        static void Main(string[] args)
        {
            // 2.Sort Arraylist of String in reverse order of its natural sorting. 

            ArrayList al = new ArrayList();
            al.Add("Sunday");
            al.Add("a");
            al.Add("Monday");
            al.Add("Saturday");
            al.Add("Tuesday");
            al.Add("Friday");
            al.Add("Wenesday");
            al.Add("Thursday");


            al.Sort();  //Natural Sorting A To Z
            al.Reverse();  //reverse al.sort()  Sorting Z to A
            foreach(object x in al)
            {
                Console.WriteLine(x);
            }


        }
    }
}
