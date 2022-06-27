using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace ConsoleApp1.Assigntment25062022
{

/*    1.	Assume you have Arraylist  al = new ArrayList();
    al.Add("Sun");
         al.Add("Mon");
         al.Add("Sat");
         al.Add("Sun ");
         al.Add("Mon ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Mon ");
         Write a code to remove duplicate elements from above list.
         Final Arraylist should contain (Sun, Mon, Sat);

*/ 
    
    
    
    
    
    
        


    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun ");
            al.Add("Mon ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Mon ");


          

                for (int i = 0; i < al.Count; i++)//0-9
                {


                    for (int j = i + 1; j < al.Count; j++)//1to9
                    {
                        if (al[i].ToString() == al[j].ToString())
                            al.Remove(al[j]);

                        if (al[i].ToString() == al[j].ToString())
                            al.Remove(al[j]);
                       
                  
                    }


                    Console.WriteLine(al[i]);

                }

            }

            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
