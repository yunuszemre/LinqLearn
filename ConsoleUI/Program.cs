using Businnes.Concreate;
using DataAccess.Concreate.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine($"{item.ProductId} {item.CategoryId} {item.ProductName} {item.UnitPrice} {item.UnitsInStock}");

            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
