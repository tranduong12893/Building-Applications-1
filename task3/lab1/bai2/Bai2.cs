using System;

namespace bai2
{
    class Bai2
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Nhap 3 so nguyen bat ky:");
			int a = Console.Read();
			int b = Console.Read();
			int c = Console.Read();
			int max=0;
			if (a >= b && a >= c)
			{
				max = a;
			}else if (b >= a && b >= c)
			{
				max = b;
			}
			else if (c >= a && c >= b)
			{
				max = c;
			}
			Console.WriteLine("So lon nhat trong 3 so [{0}, {1}, {2}] là {3}", a, b, c, max);
		
		}
    }
}
