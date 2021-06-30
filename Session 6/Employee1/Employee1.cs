using System;

namespace Employee1
{
    class Employee1
    {
        private int _empId;
        private string _empName;
        private int _age;
        private double _salary;
        Employee1(int id, string name, int age, double sal)
        {
            Console.WriteLine("Constructor for Employee called") ;
            _empId = id;
            _empName = name;
            _age = age;
            _salary = sal;
        }
        ~Employee1()
        {
            Console.WriteLine("Destructor for Employee called") ;
        }
        static void Main(string[] args)
        {
            Employee1 objEmp = new Employee1(1, "John", 45, 35000);
            Console.WriteLine("Employee ID: " +objEmp._empId);
            Console.WriteLine("Employee Name: " +objEmp._empName);
            Console.WriteLine("Age: " +objEmp._age);
            Console.WriteLine("Salary: " +objEmp._salary);
        }
    }
}
