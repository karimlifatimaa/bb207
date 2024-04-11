using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension
{
    internal class Store
    {
        private static int _id;
        public int Id;
        public Store()
        {
            _id++;
            Id = _id;
            
        }
        public Product[] products=new Product[] { };
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;

        }
        public Product[] RemoveProductByNo(int no)
        {
            
            Product[] updatedProducts = new Product[] { };
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].No != no)
                {
                    Array.Resize(ref updatedProducts, updatedProducts.Length + 1);
                    updatedProducts[updatedProducts.Length-1] = products[i];
                }
            }
            products=updatedProducts;
            return updatedProducts; 

        }
        public Product GetProduct(int no)
        {
            for(int i = 0;i < products.Length;i++)
            {
                if (products[i].No == no)
                {
                    return products[i];
                }
                else
                {
                    Console.WriteLine("Mehsul yoxdur");
                }
            }
            return null;

        }
        public Product[] FilterProductsByType(string type)
        {
            Product[] filteredProducts= new Product[] { };
            for(int i = 0;i<products.Length;i++)
            {
                if (products[i].Type == type)
                {
                    Array.Resize(ref filteredProducts, filteredProducts.Length + 1);
                    filteredProducts[filteredProducts.Length - 1] = products[i];
                }
                else
                {
                    Console.WriteLine("yoxdur");
                }
            }
            return filteredProducts;
        }
        public Product[] FilterProductsByName(string name)
        {
            Product[] filteredByName = new Product[] { };
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    Array.Resize(ref filteredByName, filteredByName.Length + 1);
                    filteredByName[filteredByName.Length - 1] = products[i];
                }
                else
                {
                    Console.WriteLine("yoxdur");
                }
            }
            return filteredByName;
        }
        


    }

}