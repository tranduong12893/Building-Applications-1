using System;

namespace Animal2
{
    class Animal2
    {
        protected string Food;
        protected string Activity;
    }
    class Cat : Animal2
    {
        static void Main(String[] args)
        {
            Cat objCat = new Cat();
            objCat.Food = "Mouse";
            objCat.Activity = "laze around";
            Console.WriteLine("The Cat loves to eat " +objCat.Food + ".");
            Console.WriteLine("The Cat loves to " +objCat.Activity + ".");
        }
    }
}
