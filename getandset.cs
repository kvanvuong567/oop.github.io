using System;
namespace Bai5{
    //Thuoc tinh (get va set)
    class Person{
        // chi truy cap trong 1 lop
        private string name;
        //truy cap toan bo , chi trong mot project
        public string Name{
            //truy cap vao name cua Private
            get {return name;}
            // cap nhat no bang gia tri 
            set { name = value;}
        }
        //HOAC DUNG MOT CACH NGAN GON
        public int Year
        {get; set;}
    }
    class program{
        static void Main(string [] agrs){
            Person myObj= new Person();
            //gan gia tri cho Name <=> name trong private 
            myObj.Name = "Vuong";
            // cap nhat hoan thanh va in ra man hinh 
            Console.WriteLine(myObj.Name);// output "Vuong"
            //Phan dung cach NGAN
            myObj.Year=1990;
            Console.WriteLine(myObj.Year);
        }
    }
}
