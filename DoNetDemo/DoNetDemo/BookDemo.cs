using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNetDemo
{
    internal class BookDemo
    {
        public class Book
        {
            private int bid;
            private string name;
            private double price;
            private string author;

            public Book(int bookId, string n, double p, string aut)
            {
                bid = bookId;
                name = n;
                price = p;
                author = aut;
            }

            public void display()
            {
                Console.WriteLine("\nBook Details:");
                Console.WriteLine($"Book ID: {bid}");
                Console.WriteLine($"Book Name: {name}");
                Console.WriteLine($"Book Price: {price:C}");
                Console.WriteLine($"Author: {author}");
            }
        }
    }
}
