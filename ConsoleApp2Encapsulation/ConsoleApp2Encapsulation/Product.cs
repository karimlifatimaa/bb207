using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Encapsulation
{
    internal class Product
    {
        private double _price;
        private int _count;
        public string No;
        public string Name;

        public double Price {
            get
            {
               return _price;
            }
            set
            {
                if(value >0) { 
                _price = value;
                }
                else
                {
                    Console.WriteLine("Duzgun daxil et");
                }
            } 
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if(value >0) { 
                _count = value; 
                }
                else
                {
                    Console.WriteLine("Duzgun daxil et");

                }
            }
        }
    }
}
