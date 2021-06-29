using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Type
{
    class Program
    {
        static void Main1(string[] args)
        {
            var stock = new { Name = "Duong", code = 1301, Price = 35056.75 };
            Console.WriteLine("Stock Name: " + stock.Name);
            Console.WriteLine("Stock Code: " + stock.code);
            Console.WriteLine("Stock Price: " + stock.Price);
            Console.Read();
        }
        public static void Main(string[] args)
        {
            Employee david = new Employee();
            david.DisplayDetail({ FirstName = "David", lastName = "Blake", Age = 30});
            Console.Read();
        }
    }
}
