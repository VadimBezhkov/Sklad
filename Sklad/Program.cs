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

            Product orange = new Product { ID = 15,Name="orange",Count=45};
            orange.Price = 55;

            SportSwear sportsSuit = new SportSwear(14, "sports suit",15002m,55,"children");

            SportSwear underShirt = new SportSwear(15,"filds", 5555m, 15, "men");

            skladProducts.AddNewProduct(apple);
            skladProducts.AddNewProduct(bananas);
            skladProducts.AddNewProduct(underShirt);
            skladProducts.AddNewProduct(sportsSuit);
            skladProducts.AddNewProduct(orange);

            Console.ForegroundColor = ConsoleColor.Red;
            decimal summ = skladProducts.GetSummAllProduct();

            Console.WriteLine($"Total amount of goods in stock: {summ}");
            Console.ResetColor();

            skladProducts.PrintAllStock();
           
            Console.ReadKey();
        }
    }
}
