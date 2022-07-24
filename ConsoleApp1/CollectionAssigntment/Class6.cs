using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{

    //6.	WAP to create List of Students and iterate over it.




    class Class6
    {
        int Id;
        string Name;
        int Mark;

        public Class6(int id, string name, int mark)
        {
            Id = id;
            Name = name;
            Mark = mark;
        }


        static void Main(string[] args)
        {

            List<Class6> ls = new List<Class6>();
            ls.Add(new Class6(500, "Ajinkya", 100));
            ls.Add(new Class6(501, "Shweta", 95));
            ls.Add(new Class6(502, "Saket", 98));


            foreach (Class6 s in ls)
            {
                Console.WriteLine($"Id : {s.Id} Name : {s.Name} Mark : {s.Mark}");
            }


        }
    }
}

