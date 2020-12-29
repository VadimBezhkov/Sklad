using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    sealed public class SkladProducts
    {
        public int WarehouseSize { get; set; }

        Product[] products;
        public string name { get; set; }

        private int productCount;

        public SkladProducts()
        {
            productCount = 0;
            WarehouseSize = 5000;
            products = new Product[WarehouseSize];
        }

        public void AddNewProduct(Product product)
        {
            product.Sklad = this;
            if (productCount>= WarehouseSize)
            {
                Console.WriteLine($"Out of stock. Product {product.Name} does not fit.");
                return;
            }
            products[productCount++] = product;
        }

        public void PrintAllStock()
        {
            for (int i = 0; i < productCount; i++)
            {
                PrintItem(products[i]);
            }
        }

        public void PrintItem(Product product)
        {
           product.PrintInfo();
        }

        public decimal GetSummAllProduct()
        {
            decimal summ = 0;

        if (products!=null && productCount>0)
            {
                foreach (var item in products)
                {
                    if(item!=null)
                    summ += item.Price*item.Count;
                }
                return summ;
            }
        else
            {
                return  0;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
