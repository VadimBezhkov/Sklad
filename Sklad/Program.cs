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
            SkladProducts skladProducts = new SkladProducts() { name = "Sklad1" };
            SkladProducts skladProducts2 = new SkladProducts() { name = "Sklad2"};


            Product apple = new Product(2001, "apple", 155m, 30);
            Product apple2 = new Product(2001, "apple", 155m, 60);
            Product bananas = new Product(1, "banan", 200m, 60);

            Product orange = new Product { ID = 15,Name="orange",Count=45};
            orange.Price = 55;

            SportSwear sportsSuit = new SportSwear(14, "sports suit",15002m,55,"children");

            SportSwear underShirt = new SportSwear(15,"filds", 5555m, 15, "men");

            skladProducts.AddNewProduct(apple);
            skladProducts2.AddNewProduct(apple2);
            skladProducts.AddNewProduct(bananas);
            skladProducts.AddNewProduct(underShirt);
            skladProducts.AddNewProduct(sportsSuit);
            skladProducts.AddNewProduct(orange);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Total amount of goods in stock1: {skladProducts.GetSummAllProduct()}");
            Console.ResetColor();

            skladProducts.PrintAllStock();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Total amount of goods in stock2: {skladProducts2.GetSummAllProduct()}");
            Console.ResetColor();
            skladProducts2.PrintAllStock();

            Console.ReadKey();
        }
    }
}
