﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1.ACollections.Date23062022
{

    class Stud
    {
        int rollno;
        string name;
        int per;

        
        public Stud(int rollno , string name , int per)
        {
            this.rollno = rollno;
            this.name = name;
            this.per = per;

        }

        public override string ToString()           // This Method Is Important 
        {
            return $"{rollno} {name} {per}";
        }







        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public int Per { get => per; set => per = value; }


        public void m(int rollno, string name, int per)
        {
            Console.WriteLine($"{rollno} {name} {per}");
        }


    }

    class CustomList
    {
        static void Main(string[] args)
        {

            List<Stud> x = new List<Stud>();

            x.Add(new Stud(01,"Aji",90));
            x.Add(new Stud(02,"Ajin",90));
            x.Add(new Stud(01, "Aji", 90));
            x.Add(new Stud(02, "Ajin", 90));
            x.Add(new Stud(01, "Aji", 90));
            x.Add(new Stud(02, "Ajin", 90));
            x.Add(new Stud(01, "Aji", 90));
            x.Add(new Stud(02, "Ajin", 90));

            x.Add(new Stud(100, "Pune", 100));

            

            foreach (object X1 in x)
            {
                Console.WriteLine(X1);
            }
           



            
        }
    }
}