using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{

/*    7.	Design class Order (int ordered, String Orderdate, Customer cust, Item item)
Customer(int custid, String custname, Address address)
Address(String addr1, city, int pincode)
Item(int itemid, String itemname, int price)
Write constructors, properties  in respective classes.
*/

    class Item
    {
        int itemid;
        String itemname;
        int price;

        public int Itemid { get => itemid; set => itemid = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public int Price { get => price; set => price = value; }
    }

    class Address
    {
        string addr1;
        string city; 
        int pincode;

        public string Addr1 { get => addr1; set => addr1 = value; }
        public string City { get => city; set => city = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
    class Customer
    {
        int custid;
        String custname;
        Address address;

        public int Custid { get => custid; set => custid = value; }
        public string Custname { get => custname; set => custname = value; }
        internal Address Address { get => address; set => address = value; }
    }


    class Order
    {
        int ordered;
        
        Customer cust;
        Item item;

        public int Ordered { get => ordered; set => ordered = value; }
    
        public Customer Cust { get => cust; set => cust = value; }
        public Item Item { get => item; set => item = value; }
    }



    class Class7
    {
        static void Main(string[] args)
        {
            Order obj = new Order();

            obj.Ordered = 1;

            obj.Cust = new Customer();
            obj.Cust.Custid = 1;
            obj.Cust.Custname="Ajinkya";

            obj.Cust.Address = new Address();
            obj.Cust.Address.Addr1 = "Bhartividyapeeth";
            obj.Cust.Address.City = "Pune";
            obj.Cust.Address.Pincode = 401210;



            obj.Item = new Item();
            obj.Item.Itemid = 10;
            obj.Item.Itemname = "Eggs";
            obj.Item.Price = 12;

            Console.WriteLine($"Order Number : {obj.Ordered}");
            Console.WriteLine($" Customer Detail :  {obj.Cust.Custid} {obj.Cust.Custname}");
            Console.WriteLine($"Customer Adress : {obj.Cust.Address.Addr1} {obj.Cust.Address.City} {obj.Cust.Address.Pincode}");

            Console.WriteLine($"Item Detail : {obj.Item.Itemid} {obj.Item.Itemname} {obj.Item.Price}");
            

        }
    }
}
