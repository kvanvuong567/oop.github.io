using System;
namespace Bai3{
    //----Phuong thuc doi tuong
    //---- day la lop ngoai class program
    class Car 
    {
        //dung public de truy cap 
        //tai sao chung ta dung public ma khong phai la static 
        //vi static truy cap ma ko can tao doi tuong cho lop 
        // public cac phuong thuc chi co the duoc truy cap boi cac doi tuong
     public string model;
     public string color;
     public int year;
     public void fullThrottle()
     {
         Console.WriteLine("The car is going as fast as it can!"); 
     }
    }
    class program{
        static void Main(string [] agrs){
            Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model); 
        }
    }
}