using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    public class Product
    {
        private int _iD;
        private string _name;
        private decimal _price;
        private int _count;
        private SkladProducts _sklad;
        public SkladProducts Sklad
        {
            get { return _sklad; }
            set { _sklad = value; }
        }
    
        public int ID
        {
            set
            {
                if (value > 200000)
                {
                    Console.Write("Invalid product id:  ");
                }
                else
                {
                    _iD = value;
                }
            }
            get { return _iD; }
        }
        public string Name
        {
            set
            {
                if (value == "fuck")
                {
                    Console.Write("Such a name should not be:  ");
                }
                else
                {
                    _name = value;
                }
            }
            get { return _name; }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 300000)
                {
                    Console.Write("Nobody will buy such a product");
                }
                else
                {
                    _price = value;
                }
            }
        }
        public int Count
        {
            get { return _count; }
            set
            {
                if (value > 500000)
                {
                    Console.Write("The warehouse will not accept so many goods");
                }
                else
                {
                    _count = value;
                }
            }
        }
        public Product()
        {

        }
        public Product(string name)
        {
            Name = name;
        }
        public Product(string name, decimal price) :this (name)
        {
            Price = price;
        }
        public Product(int iD)
        {
            ID = iD;
        }
        public Product(int iD, string name):this (iD)
        {
            Name = name;
        }
        public Product(int iD, string name, decimal price):this (iD, name)
        {
            Price = price;
        }
        public Product(decimal price)
        {
            Price = price;
        }
        public Product(int iD, string name, decimal price, int count):this (iD,name,price)
        {
            Count = count;
        }
        public Product(int iD, decimal price, int count):this ( iD, price)
        {
            Count = count;
        }
        public Product(string name, decimal price, int count):this (name,price)
        {
            Count = count;
        }
        public Product(int iD, decimal price):this (iD)
        {
            Price = price;
        }
        public Product(int iD, int count) : this(iD)
        {
            Count = count;
        }
        
        public override string ToString()
        {
            return $"{Sklad}\nProduct ID: {ID},  Product Name: {Name}," +
                $" Product Price: {Price}, Products Count: {Count}";
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
        public void PriceProduct()
        {
            Console.WriteLine(_price*_count);
        }
    }
}
