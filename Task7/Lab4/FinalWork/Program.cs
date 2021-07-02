using System;

namespace FinalWork
{
    namespace FinalWork
    {
        abstract class Human
        {
            public string name;
            public string phoneNumber;
            public string address;
            public Human(string name, string phone, string add)
            {
                this.name = name;
                this.phoneNumber = phone;
                this.address = add;
            }

            public override string ToString()
            {
                return "Person Info: " + name + "," + phoneNumber + "," + address;
            }
        }

        class Student : Human
        {
            string program;
            public Student(string name, string phoneNumber, string address, string program) : base(name, phoneNumber, address)
            {
                this.program = program;
            }
            public string display()
            {
                return "Student Info: " + name + "," + phoneNumber + "," + address + "," + program;
            }
        }
        abstract class Employee : Human
        {
            public string department;
            public float salary;
            public string dateHired;
            public int officeHours;
            public int week;
            public Employee(string name, string phoneNumber, string address, string department, float salary, string dateHired, int officeHours, int week) : base(name, phoneNumber, address)
            {
                this.department = department;
                this.salary = salary;
                this.dateHired = dateHired;
                this.officeHours = officeHours;
                this.week = week;
            }
            public abstract void CalculateBonus();
            public abstract void CalculateVacation();

        }
        class Faculty : Employee
        {
            string rank;
            public Faculty(string name, string phoneNumber, string address, string department, float salary, string dateHired, int officeHours, int week, string rank) : base(name, phoneNumber, address, department, salary, dateHired, officeHours, week)
            {

                this.rank = rank;
            }
            public override void CalculateBonus()
            {
                Console.WriteLine(name + "'s Bonus: " + (salary * 0.05 + 1000));
            }
            public override void CalculateVacation()
            {
                if (rank == "Senior Lecturer")
                {
                    week = week + 1;
                }
                if (officeHours >= 26208)
                {
                    week = week + 5;
                }
                else
                {
                    week = week + 4;
                }
                Console.WriteLine(name + "'s Vacation: " + week + " week(s)");
            }
            public string display()
            {
                return "Faculty Info: " + name + "," + phoneNumber + "," + address + "," + department + "," + salary + "," + dateHired + "," + officeHours + "," + week + "," + rank;
            }

        }
        class Staff : Employee
        {
            string title;
            public Staff(string name, string phoneNumber, string address, string department, float salary, string dateHired, int officeHours, int week, string title) : base(name, phoneNumber, address, department, salary, dateHired, officeHours, week)
            {
                this.title = title;
            }
            public override void CalculateBonus()
            {
                Console.WriteLine(name + "'s Bonus: " + (salary * 0.06));
            }

            public override void CalculateVacation()
            {
                if (officeHours >= 43680)
                {
                    week = week + 4;
                }
                else
                {
                    week = week + 3;
                }
                Console.WriteLine(name + "'s Vacation: " + week + " week(s)");
            }
        }
        class run
        {
            static void Main(string[] args)
            {
                Faculty sb = new Faculty("Kim THi", "123456789", "DKTHI@FPT.EDU.VN", "clerk", 5000000, "1/1/2015", 58800, 125, "Expert");
                Console.WriteLine(sb.display());
                sb.CalculateBonus();
                sb.CalculateVacation();
                Console.ReadLine();
            }
        }

    }
}
