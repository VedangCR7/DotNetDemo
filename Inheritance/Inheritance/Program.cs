using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Banking Main
            //SavingAccount sa = new SavingAccount(2000);
            //sa.Deposite(1000);
            //sa.Withdraw(1500);

            //CurrentAccount ca = new CurrentAccount(2000);
            //ca.Deposite(1000);
            //ca.Withdraw(1000);

            //Shape Main
            //Circle c=new Circle(2);
            //c.CalculateArea();
            //c.CalculatePeriemter();

            //Triangle t = new Triangle(2,3,4);
            //t.CalculateArea();
            //t.CalculatePeriemter();

            //Employee Main
            //PartTimeEmployee pte = new PartTimeEmployee { Id = 1,Name = "John", HoursWorked = 30 };
            //pte.CalculateSalary();

            //FullTimeEmployee fte =new FullTimeEmployee { Id=1,Name="Alan",HoursWorked = 60};
            //fte.CalculateSalary();

            //Flyable Interface
            IFlyable sc = new SpaceCraft();
            sc.FlyObj();

            IFlyable ap = new Airplane();
            ap.FlyObj();

            IFlyable h = new Helicopter();
            h.FlyObj();
        }
    }
}
