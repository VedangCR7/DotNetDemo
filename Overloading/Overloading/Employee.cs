using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            Id = 101;
            Name = "Alice";
            Salary = 1000;
        }

        public Employee(string name)
        {
            Id = 102;
            Name = name;
            Salary= 2000;
        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }   

        public void Display()
        {
            Console.WriteLine("Employee Id " + Id);
            Console.WriteLine("Employee Name " + Name);
            Console.WriteLine("Employee Salary " + Salary);


        }
    }
}
