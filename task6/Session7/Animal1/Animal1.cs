using System;

namespace Animal1
{
    class Animal1
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }
        public void DoSomething()
        {
            Console.WriteLine("Every animal does something.");
        }
    }
    class Cat : Animal1
    {
        static void Main(String[] args)
        {
            Cat objCat = new Cat();
            objCat.Eat();
            objCat.DoSomething();
        }
    }
}
