using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension
{
    internal class Product
    {
        private static int _no;
        public int No;
        public string Type;
        
        public int Count;

        public Product(string name, int price, string type)
        {
            _no++;
            No=_no;
        
            Name = name;
            Price = price;
            Type = type;
        }
        public string Name;
        private int _price;
        public int Price {
            get
            {
                return _price;

            }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Menfi price ola bilmez");
                }

            } 
        }
       
        public override string ToString()
        {
            return $"No : {No} , Name : {Name} , Price : {Price} , Type : {Type} , Count : {Count} ";
        }
    }
}
