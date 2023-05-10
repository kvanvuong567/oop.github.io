using System;
namespace Bai3{
    //Thanh vien lop (class)
    //Tao mot lop Car voi ba thanh vien lop: hai truong va mot phuong thuc
    class Car{
        //khoi tao hai truong 
        string color="red";
        int maxSpeed=200;
        // ban cung co the de trong truong va su chung khi tao doi tuong 
        string made;
        // vi du chung ta du thong tin cua mot chiec xe nao do 
        string model;//kieu xe
        string color1; //mau xe
        int year;//nam san xuat
        //--------------
        static void Main(string [] agrs){
            Car myObj1= new Car();
            Console.WriteLine("color: " + myObj1.color);
            Console.WriteLine("maxSpeed: "+ myObj1.maxSpeed);
            //ban cung co the de trong truong va su chung khi tao doi tuong 
            myObj1.made="Vietnams";
            Console.WriteLine("MADE IN: "+ myObj1.made);
            //---vi du
            Car xedap = new Car();//xe dap
            //gan cac thong tin cho xe
            xedap.model="moi nhat";//loai moi nhat
            xedap.color1="mau den";//xe co mau den
            xedap.year=2023;//san xuat nam 2023
            Car xemoto = new Car();// xe moto
            //gan thong tin cho xe
            xemoto.model="100 phan khoi";// loai 100 phan khoi
            xemoto.color1="mau do";//co mau do
            xemoto.year=2013;//san xuat nam 2013
            //-----Xuat du lieu model cua 2 xe
            Console.WriteLine("xe dap:" +xedap.model);
            Console.WriteLine("xe moto:" +xemoto.model);
            //----------------
        }
    }
}
