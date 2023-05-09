using System;
namespace Bai2{
    //Tao nhieu lop (class) va nhieu doi tuong 
    //Tao mot lop xe hoi , trong c# ta co the tao no ben ngoai lop Program de gon gan hon
    //Con day la tui dang code tren web nen tui se de chung mot cho nhung cach bieu thi cung gan giong voi tao no ben ngoai
    //Luu y khi tao no thi no phai cung mot du an (Project) va cung namespace
    class Car{
        //public la cong cu sua doi truy cap
        /*Chi dinh rang bien cua color trong truong cua lop Car cung co the truy cap 
        duoc doi voi cac lop khac, chang han nhu la Program*/
        public string color="red";
    }
    class program{
        static void Main (string [] agrs){
            //Su dung nhieu doi tuong 
            Car myObj1= new Car();
            Car myObj2= new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }
}