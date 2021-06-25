using System;

namespace lab1
{
    class Bai1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ten cua ban:");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap dia chi cua ban:");
            string address = Console.ReadLine();
            Console.WriteLine("Nhap so dien thoai cua ban:");
            string Tel = Console.ReadLine();
            Console.WriteLine("Ten cua ban la: "+ name);
            Console.WriteLine("Ban song tai dia chi: "+ address);
            Console.WriteLine("So dien thoai cua ban la: "+ Tel);
        }
    }
}
