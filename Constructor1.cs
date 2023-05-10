using System;
namespace Bai4{
    //Constructors: Trinh xay dung
    //la mot phuong thuc dac biet duoc su dung de khoi tao objects
    //Uu diem: duoc goi khi mot object of the class duoc tao 
    //duoc su dung de dat gia tri ban dau cho cac truong 
    class Car {
        // tao mot ham public 
        public string model;//Create a field
        //Create a class Constructor for the Car class
        //Tao mot lop Constructor cho lop xe 
        //Luu y ten Constructor phai khop voi ten lop va khong duoc co kieu tra ve nhu "void" hoac "int"
        public Car(){
            //Constructor duoc tao khi doi tuong model duoc tao 
            model="xe do";//Dat gia tri ban dau cho model
        }
    //khong can class program
    static void Main(){
        Car Ford=new Car();
        Console.WriteLine("Model: " +Ford.model);
     }
     //Tat cac lop de co Constructor mac dinh: neu ko tu tao mot Constructor cua lop, c# se tu tao Constructor 
     //Tuy nhien, tiep theo chung ta khong the dat gia tri ban dau cho cac truong
   }
}