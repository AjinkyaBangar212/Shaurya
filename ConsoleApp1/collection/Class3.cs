using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    //non genric class
    class K 
    {

        private object ob;
        public object Ob { get; set; }
    
    }



    //genric class

    class KK<T>
    {
        private T ob;
        public T Ob { get; set; }
    }



    class Class3
    {
        static void Main(string[] args)
        {

            KK<string> obj = new KK<string>();

            obj.Ob = "XYZ";
            string s = obj.Ob;







            K k = new K();

            k.Ob = "Sima";
            k.Ob = 90;

            int m = (int)k.Ob;


        }
    }
}
