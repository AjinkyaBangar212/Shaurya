using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{

    /*8.	Create a class Account with member Variable: 
long account No, String customer Name ,balance
Make them public.
Create default constructor assign new value to all variables and print I am in default constructor.
Create constructor which takes all arguments and assigns those values to the member variables and print I am in parameterized constructor.
Create properties

Methods –

void deposit amount
withdraw () to withdraw amount
 check_balance() to check balance
*/


    class Account
    {
        long accno;
        string custname;
        long balance=2000;
        long sum;

        public long Accno { get => accno; set => accno = value; }
        public string Custname { get => custname; set => custname = value; }
        public long Balance { get => balance; set => balance = value; }
        public long Sum { get => sum; set => sum = value; }

        public Account()
        {
            Console.WriteLine("I am default constructor");
        }

        public Account(long Accno,string Custname)
        {
            Console.WriteLine("I Am Parameterized Constructor");
            Console.WriteLine($"Acc no : {Accno}  Customer Name : {Custname}  Balance : {Balance}");
        }


       public void Deposit (long add)
        {
            Sum = Balance + add;
            Console.WriteLine($"Your Balance after Depositing {add} rs is {Sum} ");
            Amount();

        }

        public void Amount()
        {
            Console.WriteLine("Welcome");
            check_balance();
        }

      

        public void check_balance()
        {
            Console.WriteLine($"You Current Balance is : {sum}");
        }

        

    }





    class Class8
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Your Balnce is 2000");


            Account obj = new Account(15268981989 , "Ajinkya");
       

            
            Console.WriteLine("Deposite Balance");
           long add = long.Parse(Console.ReadLine());


            obj.Deposit(add);
       

            

        }
    }
}
