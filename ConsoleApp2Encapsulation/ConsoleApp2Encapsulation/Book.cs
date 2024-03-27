using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2Encapsulation
{
    internal class Book:Product
    {
        public string Genre;
        public Book(string no,double price,string name,string genre)
        {
            No = no;
            Price= price;
            Name = name;
            Genre = genre;
        }
        public void ShowInfo()
        {

            Console.WriteLine($"No: {No}, Price: {Price}, Name: {Name}, Genre: {Genre}");
        }
    }
}
