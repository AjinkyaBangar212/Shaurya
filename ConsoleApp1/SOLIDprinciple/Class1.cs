using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SOLIDprinciple
{

    class Animal   // example of S -Single Responsiblity Relevent things are go in relevent class like animal relevent - cat ,dog
    {

        public void Dog()
        {

        }

        public void Cat()
        {

        }
    }


     // O - open close    Open for Extension and Close For Modification 
   
   abstract class Bank  // O - Open for Extension and Close For Modification 
    {

        abstract public void EditAccdetail();  // if you want to accesss the EditDetail () method you can access it for writing new code
                                               //but you cant modify it

    }

    class Customer : Bank
    {
        public override void EditAccdetail()
        {

        }
    }

    class take : Bank
    {
        public override void EditAccdetail()
        {
            Console.WriteLine("You can add your logic here that mean open for Extention or open for reusablity but " +
                              "  not for modification");
        }
    }


    // Liskov Principle
    class Dog
    {
      // you can see the reletion bet dog and puppy 
      //never write unnessesary Reletion in Parent and class ex - parent dog and base is horse
      //always write nessesary reletion between parent and child
    }

    class Puppy : Dog
    {

    }


    // I -  Interface Segrigation
    
    interface Car1
    {
        abstract void car();
        abstract void carEngine();

        abstract void Truck();    // Dont Put All Abstract method in Same Interface Create Diffrent Interface
                                 // coz when you using interface that time you need to use all abstract method
                                 //so write diffrent- diffrent interfaces ex truck and Sport Car
        abstract void TruckEngine(); 

    }


    interface Truck
    {
        abstract void TruckModel();
        abstract void TruckColor();
    }

    interface SportCar
    {                  
        abstract void SportCarModel();
        abstract void SportCarColor();
    }






    //D - dependency

    class Student
    {
        //never Create or Contain a object of class in same class

        public void run()
        {

        }

        //never create object here for calling run method always create outside the current class
        //as well as never create object inside the Child Class Also
        //for ex object create in Class1 inside Static void main
        
    }




    class Class1
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.run();
        }
    }
}
