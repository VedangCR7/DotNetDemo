using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace DoNetDemo
{
    //internal class Employee
    //{
    //}\

    public class Employee
    {
        private int id;
        private string name;
        private double salary , hra,da,pf ,gross;
        private static int count;

        static Employee ()
        {
            count = 100;
        }
        public Employee(string name, double salary) {
            count++;
            this.id= count;
            this.name= name;
            this.salary= salary;
        
        }

        //public int Id
        //{
        //    set { id = value; }
        //    get { return id; }
        //}

        //public string Name
        //{
        //    set { name = value; }
        //    get { return name; }
        //}

        //public double Salary
        //{
        //    set { salary = value; }
        //    get { return salary; }
        //}

        public void CalculateSalary()
        {
            hra = salary * 0.40; // 40% of basic salary
            da = salary * 0.20;
            pf = salary * 0.12;
            gross = (salary + hra + da) - pf;
        }


        public string Display()
        {
            return $"Your info is {id} {name} {gross} ";
        }

    }
}
