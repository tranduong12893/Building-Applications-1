using System;

namespace OptionalParameterExample
{
    class OptionalParameterExample
    {
        static void Main(string[] args)
        {
            void printMessage(String message ="Hello user!") 
            {
                Console.WriteLine("{ 0}", message);
            }
            static void Main(string[] args)
            {
                OptionalParameterExample opExample = new OptionalParameterExample();
                opExample.printMessage("Welcome User!");
                opExample.printMessage();
            }
        }
    }
}
