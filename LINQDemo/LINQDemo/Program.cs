using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Price=799,CompanyName="Dell"},
                new Product{Id=2,Name="Mouse",Price=699,CompanyName="Lenovo"},
                new Product{Id=3,Name="Laptop",Price=34799,CompanyName="Dell"},
                new Product{Id=4,Name="Laptop",Price=45799,CompanyName="Sony"},
                new Product{Id=5,Name="Laptop",Price=38799,CompanyName="Lenovo"},
                new Product{Id=6,Name="Keyboard",Price=599,CompanyName="Dell"},
                new Product{Id=7,Name="Keyboard",Price=999,CompanyName="Microsoft"},
                new Product{Id=8,Name="RAM 4GB",Price=2799,CompanyName="Corsair"},
                new Product{Id=9,Name="Speaker",Price=5799,CompanyName="Sony"},
                new Product{Id=10,Name="USB Mouse",Price=1299,CompanyName="Microsoft"},
            };

            Console.WriteLine("All Products:");
            var allProducts = from p in products select p;
            foreach (var p in allProducts)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\nProducts with Price > 1500:");
            var productsAbove1500 = from p in products
                                    where p.Price > 1500
                                    select p;
            foreach (var p in productsAbove1500)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\nProducts with Price between 10000 and 40000:");
            var productsInRange = from p in products
                                  where p.Price >= 10000 && p.Price <= 40000
                                  select p;
            foreach (var p in productsInRange)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\nProducts from Dell:");
            var dellProducts = from p in products
                               where p.CompanyName == "Dell"
                               select p;
            foreach (var p in dellProducts)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\nAll Company Laptops:");
            var laptops = from p in products
                          where p.Name.Contains("Laptop")
                          select p;
            foreach (var p in laptops)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\nProducts with Company Name starting with 'M':");
            var companyStartsWithM = from p in products
                                     where p.CompanyName.StartsWith("M")
                                     select p;
            foreach (var p in companyStartsWithM)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\nCompany Mouse with Price < 1000:");
            var cheapMice = from p in products
                            where p.Name.Contains("Mouse") && p.Price < 1000
                            select p;
            foreach (var p in cheapMice)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\nProducts in Descending Order by Price:");
            var productsDescendingByPrice = from p in products
                                            orderby p.Price descending
                                            select p;
            foreach (var p in productsDescendingByPrice)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\nProducts in Ascending Order by Company Name:");
            var productsAscendingByCompanyName = from p in products
                                                 orderby p.CompanyName
                                                 select p;
            foreach (var p in productsAscendingByCompanyName)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\nKeyboards in Ascending Order by Price:");
            var keyboardsAscendingByPrice = from p in products
                                            where p.Name.Contains("Keyboard")
                                            orderby p.Price
                                            select p;
            foreach (var p in keyboardsAscendingByPrice)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            //using Lamda Expression
            Console.WriteLine("\n -------------------------------Using Lamda Expressoin-----------------------------------------");

            Console.WriteLine("\n1 Products in Descending Order by Price:");
            var dbyp = products.OrderByDescending(p => p.Price);
            foreach (var p in dbyp)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\n2 Product with Id = 5:");
            var productWithId5 = products.FirstOrDefault(p => p.Id == 5);
            if (productWithId5 != null)
                Console.WriteLine($"{productWithId5.Id} - {productWithId5.Name} - {productWithId5.Price} - {productWithId5.CompanyName}");

            Console.WriteLine("\n3 Products with Price < 5000:");
            var productsBelow5000 = products.Where(p => p.Price < 5000);
            foreach (var p in productsBelow5000)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\n4 Products with Maximum Price:");
            var top3ProductsByPrice = products.OrderByDescending(p => p.Price).Take(3);
            foreach (var p in top3ProductsByPrice)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");

            Console.WriteLine("\n5 Products with Minimum Price:");
            var top5ProductsByMinPrice = products.OrderBy(p => p.Price).Take(5);
            foreach (var p in top5ProductsByMinPrice)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.CompanyName}");
        }
    }
}
