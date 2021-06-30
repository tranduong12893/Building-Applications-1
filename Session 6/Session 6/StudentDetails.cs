using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6
{
    class StudentDetails
    {
        string studName = "james";
        int rollNumber = 20;

        static void Main1 (string[] args)
        {
            StudentDetails objStudents = new StudentDetails();
            Console.WriteLine("Student Name: " + objStudents.studName);
            Console.WriteLine("Roll Number: " + objStudents.rollNumber);
        }
    }
}
