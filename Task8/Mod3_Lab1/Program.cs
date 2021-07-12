using System;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(20, 40);
            Console.WriteLine($"The sum of 20 and 40 is: {result}");

            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"calling Sum() with three arguments, result is: {result3}");

            double dblresult = Sum(20.5, 30.6);
            Console.WriteLine($"calling Sum() that  takes doubles result is: {dblresult}");

        }
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
            Console.WriteLine($"The sum of {first} and {second} is: {sum}");
        }
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }
        
        static double Sum( double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
