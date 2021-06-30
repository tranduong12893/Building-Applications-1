using System;

namespace task_4
{
    class Students
    {
        string _studName = " james Anderdon";
        int _studAge = 27;
        void Display()
        {
            Console.WriteLine("Student Name: " + _studName);
            Console.WriteLine("Student Age: " + _studAge);
        }
        static void Main(string[] args)
        {
            Students objStudents = new Students();
            objStudents.Display();
        }
    }
}
