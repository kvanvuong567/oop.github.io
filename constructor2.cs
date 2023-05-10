using System;
namespace Bai4{
    //Constructor2
    //Tham so Constructor (Constructor Parameters)
    //khoi tao lop char
    class Car{
        // khoi tao truy cap co dinh public
        public string model;//create a field
        // ta co the tao nhieu tham so 
        public string color;
        public int year;
        //create a class Constructor with a parameter 
        //tao mot lop constructor voi 1 tham so
        public Car(string modelName,string colorName, int numberYear){
            //dat model = modelName
            model = modelName;
            color = colorName;
            year = numberYear;
        }
        static void Main(string[] agrs){
            //truyen 1 tham so XE DO cho constructor 
            //tham so nay se dat gia tri model thanh XE DO
            Car Ford = new Car("XE DO","mau do",1982);
            Console.WriteLine(Ford.model +" "+ Ford.color +" "+ Ford.year);
        }
        //giong nhu cac phuong thuc khac, constructor co the duoc nap chong bang cach cu luong tham so khac nhau
    }
}