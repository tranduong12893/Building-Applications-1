using System;

namespace Extension_Methord
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = "American";
            Console.WriteLine(country.FirstLetterLower());
            List<string> cities = new List<string>();
            cities.Add("Seoul");
            cities.Add("beijing");
            cities.Add("Berlin");
            cities.Add("Istanbul");
            cities.Add("Seoul");
            cities.Add("Istanbul");
            cities.Add("paris");
            cities.Add("Hanoi");
            List<string> result = cities.RemoveDuplicate();
            foreach (string city in result)
                Console.WriteLine(city);
        }
    }
}
