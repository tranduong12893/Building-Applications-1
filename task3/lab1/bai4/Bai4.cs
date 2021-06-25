using System;

namespace bai4
{
    class Bai4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hay nhap 1 so:");
            int n = Console.Read();
            for(int i = 1; i<=9; i++)
            {
                const string V = " = ";
                Console.WriteLine(n + " x " + i +V + n* i);
            }
        }
    }
}
