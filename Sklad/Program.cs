using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    class Program
    {
        static void Main(string[] args)
        {
            SkladProducts skladProducts = new SkladProducts();

            Product apple = new Product(2001, "apple", 155m, 30);

            Product bananas = new Product(1, "banan", 200m, 60);

            SportSwear undershirt = new SportSwear(15,"filds", 5555, 15, "men");

            skladProducts.AddNewProduct(apple);
            skladProducts.AddNewProduct(bananas);
            skladProducts.AddNewProduct(undershirt);

            Console.ForegroundColor = ConsoleColor.Red;
            decimal summ = skladProducts.GetSummAllProduct();
            Console.WriteLine($"Total amount of goods in stock: {summ}");

            Console.ResetColor();

            skladProducts.PrintAllStock();
           
            Console.ReadKey();
        }
    }
}
