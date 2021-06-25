using System;

namespace bai5
{
    class bai5
    {
        static void Main(string[] args)
        {
            decimal res = 1, n;
            for(n = 20; n >0; n--)
            {
                res *= n;
            }
            Console.WriteLine("Giai thua cua cac so nguyen tu 1 den 20 la:" + res);
        }
    }
}
