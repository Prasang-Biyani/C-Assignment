using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Inventory
    {
        public List<Product> products;
        int totalAmount = 0;
        public Inventory()
        {
            products = new List<Product>();
        }
        internal void getCount()
        {
            Console.WriteLine("Number of Products are: " + products.Count());
        }

        internal void Add(Product product)
        {
            products.Add(product);
        }

        internal void findProduct(string type)
        {
            foreach(var product in products)
            {
                if (product.Type == type)
                    Console.WriteLine(product.Name + " " + product.Price + " " + product.Quantity);
            }
            Console.WriteLine();
        }

        internal void deleteProduct(string name)
        {
            int index = 0;
            foreach (var product in products)
            {
                if (product.Name == name)
                    break;
                index++;
            }
            products.RemoveAt(index);
            Console.WriteLine();
        }

        internal void addQuantity(string name, int quantity)
        {
           foreach(var product in products)
            {
                if(product.Name == name)
                {
                    product.Quantity += quantity;

                }
            }
        }

        internal void printAll()
        {
            foreach(var product in products)
                Console.WriteLine(product);
        }

        internal void addCart(string name, int quantity)
        {
            foreach(var product in products)
            {
                if(product.Name == name)
                {
                    totalAmount += ((int)product.Price * quantity);
                }
            }
        }

        internal int totalSum()
        {
            return totalAmount;
        }



        //string Name { get; set; }
        //double Price { get; set; }
        //int Quantity { get; set; }
        //string Type { get; set; }

        //List<Inventory> inventories;

        //public Inventory() { }
        //public Inventory(string name, double price, int quantity, string type)
        //{
        //    this.Name = name;
        //    this.Price = price;
        //    this.Quantity = quantity;
        //    this.Type = type;


        //}

        //internal void totalProducts(List<Inventory> inventories)
        //{
        //    Console.WriteLine("Total Number of Products : " + inventories.Count);
        //}

        //internal void addProduct(Inventory inventories)
        //{
           
        //}

    }
}
