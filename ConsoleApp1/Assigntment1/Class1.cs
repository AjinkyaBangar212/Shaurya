using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{
   // Q1

   abstract class Teacher
    {
        int Tid;
        string Tname;
        long MobileNo;

        public Teacher(int Tid , string Tname, long MobileNo)
        {
            this.Tid = Tid;
            this.Tname = Tname;
            this.MobileNo = MobileNo;
            
        }
          public abstract void salary();

    }


   class Hourlybased:Teacher
    {
        int rate_per_hr;
	    int hrs;

        public Hourlybased(int rate_per_hr,int hrs):base(1,"Aji",905050)
        {
            this.rate_per_hr = rate_per_hr;
            this.hrs = hrs;   
        }

       public override void salary()
        {

            Console.WriteLine(hrs +"  " + rate_per_hr);
           
        }

}

    class SalaryBased:Teacher
    {
        int sal;

        public SalaryBased(int id,string nm,int mob,int salary1) : base(1, "Aji", 905050)
        {
            this.sal = salary1;
        }

        public override void salary()
        {
            Console.WriteLine(sal);

        }



    }








    class Class1
    {
        static void Main(string[] args)
        {
           

            SalaryBased obj = new SalaryBased(90000,"Aji",10,10);
            obj.salary();

            Hourlybased obj1 = new Hourlybased(6000,90);
            obj1.salary();


            obj1.salary();

        }
    }
}
