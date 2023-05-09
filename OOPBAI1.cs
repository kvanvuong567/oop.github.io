//-------------
/*Hoc LAP Trinh huong doi tuong c#
----------K VAN VUONG --------*/
//lop(class) la khuon mau cho cac doi tuong 
//Doi tuong (object) la the hien cua 1 lop
//Khi cac object duoc tao rieng le,chung ke thua tat ca cac bien va phuong thuc tu lop 
//khai bao thu vien
using System;
namespace Bai1{
    //Tao mot lop xe hoi
    class Car{
        string color="red";
        //-------------
        //HAM CHINH
        static void Main (string [] agrs){
            // Tao mot doi tuong co ten la myObj va su dung no de in gia tri color
            Car myObj= new Car();
            //Su dung dau cham (.) de truy cap cac bien ben trong truong cua mot lop
            Console.WriteLine(myObj.color);
        }
    }
}