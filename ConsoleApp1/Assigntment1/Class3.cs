using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1

/*{3.	Write a java program to create 2 person objects.Take input or hardcode  for all two person from console.Person class is as follows
Person(int id, String name, Vehicle v)
Vehicle(int vid, String vname)
*/

{ 

    class Vehical
    {
        int vid;
        string vname;


          public Vehical(int vid,string vname)
        {
            this.vid = vid;
            this.vname = vname;
        }
        public void Show2()
        {
            Console.WriteLine(vid + vname);
        }
    }

    class Person
{
    int id;
    string name;
        Vehical v;

        public Person(int id,string name,Vehical v)
    {
        this.id = id;
        this.name = name;
            this.v = v;
    }

    public void S()
    {
        Console.WriteLine($"Person id : {id}  Preson Name : {name}");

            v.Show2();
    }


}







    class Class3
{
    static void Main(string[] args)
    {

            Person p = new Person(1001,"Ram",new Vehical(20,"Pulsure"));
            p.S();
    }
    }
}
