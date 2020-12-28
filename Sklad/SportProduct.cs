using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    public class SportSwear:Product
    {
        private byte _size;
        private string _sex;
        public byte Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }


        public SportSwear():base()
        {

        }
        public SportSwear(int iD, string name, decimal prise, int count,byte size,string sex) :base( iD, name, prise, count)
        {
            _size = size;
            _sex = sex;
        }
        public SportSwear(int iD, string name, decimal prise, byte size, string sex) : base(iD, name, prise)
        {
            _size = size;
            _sex = sex;
        }
        public SportSwear(int iD, string name,  int count, byte size, string sex) : base(iD, name,count)
        {
            _size = size;
            _sex = sex;
        }
        public SportSwear(string name, decimal prise, int count, byte size, string sex) : base(name, prise, count)
        {
            _size = size;
            _sex = sex;
        }
        public SportSwear(int iD, decimal prise, int count, byte size, string sex) : base(iD, prise, count)
        {
            _size = size;
            _sex = sex;
        }

        public override string ToString()
        {
            return $"{Sklad}:  THIS IS SportProduct \nProduct ID: {ID},  Product Name: {Name}," +
                $" Product Price: {Price}, Products Count: {Count}, Size{_size} SEX: {_sex}";
        }

        //public override void PrintInfo()
        //{
        //    Console.WriteLine(ToString());
        //}
    }
}
