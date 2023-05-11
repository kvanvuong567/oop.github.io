using System;
namespace Bai6{
    //Ke thua c#
    // tao mot lop dau ben ngoai lop program
    class Vehicle{//base class
        //khoi tao truy cap public
        public string brand = "Ford";//truong
        public void honk(){//phuong thuc
            Console.WriteLine("Tuut, Tuut!");
        }
    }
    // khoi tao mot lop con ben ngoai lop Vehicle
    // su dung ky hieu (:) de the hien tinh ke thua
    class Car : Vehicle {
        //khoi tao truy cap public
        public string modelName="Xe do";
    }
    //ham thuc thi chinh
    class program {
        static void Main(){
            Car myObj= new Car();
            //goi phuong thuc honk() tren doi tuong myObj
            myObj.honk();
            //Xuat gia tri brand tu lop Vehicle va modelName tu lop con Car
            Console.WriteLine(myObj.brand + " " + myObj.modelName);//output "Ford Xe do"
        }
        //Neu ban khong muon lop khac ke thua tu mot lop 
        //hay su dung le sealed
        //vi du:
        // sealed class Vehicle{-----}
        //class Car : Vehicle {----} // lop nay  se ko dc ke thua 
    }
}