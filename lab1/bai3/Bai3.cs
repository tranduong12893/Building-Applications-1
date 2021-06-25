using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap 1 so bat ky tu 1->7:");
            int number = int.Parse(Console.ReadLine());
            if( number == 1)
            {
                Console.WriteLine("Hom nay la thu 2!");
            }else if (number == 2)
            {
                Console.WriteLine("Hom nay la thu 3!");
            }else if (number == 3)
            {
                Console.WriteLine("Hom nay la thu 4!");
            }
            else if (number == 4)
            {
                Console.WriteLine("Hom nay la thu 5!");
            }
            else if (number == 5)
            {
                Console.WriteLine("Hom nay la thu 6!");
            }
            else if (number == 6)
            {
                Console.WriteLine("Hom nay la thu 7!");
            }
            else if (number == 7)
            {
                Console.WriteLine("Hom nay la thu Chu nhat!");
            }
        }
    }
}
