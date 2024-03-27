using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Encapsulation
{
    internal class Library
    {
        Book[] Books = new Book[] { };
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1] = book;
        }
        public Book[] GetFilteredBooks(string genre)
        {
            Book[] filteredBooks= new Book[] { };
            for(int i=0; i < Books.Length; i++)
            {
                if (Books[i].Genre == genre)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length-1] = Books[i];
                    
                }
            }
            return filteredBooks;
        } 
        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            Book[] filteredBooks = new Book[] { };
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price >= minPrice && Books[i].Price<=maxPrice)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = Books[i];

                }
            }
            return filteredBooks;
        }
        public void ShowAllBooks()
        {
            for(int i = 0;i < Books.Length;i++)
            {
                Console.WriteLine($"No: {Books[i].No}, Price: {Books[i].Price}, Name: {Books[i].Name}, Genre: {Books[i].Genre}");
            }
        }







    }
}
