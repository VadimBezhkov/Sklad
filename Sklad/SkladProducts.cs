using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    sealed public class SkladProducts
    {
        Product[] products = new Product[5000];

        private int productCount = 0;

        public void AddNewProduct(Product product)
        {
            product.Sklad = this;
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
            Console.WriteLine(product.ToString());
        }
        public decimal GetSummAllProduct()
        {
            decimal summ = 0;
        if (products!=null && productCount>0)
            {
                foreach (var item in products)
                {
                    if(item!=null)
                    summ += item.Price;
                   
                }
                return summ;
            }
        else
            {
                return  0;
            }

        }

    }
}
