using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
            inventory.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            inventory.Add(new Product("pumpkin", 30, 30, "Marrow"));
            inventory.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            inventory.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            inventory.Add(new Product("yam", 30, 50, "Root"));
            inventory.Add(new Product("spinach", 10, 100, "Leafy green"));
            inventory.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            inventory.Add(new Product("garlic", 30, 20, "Leafy green"));
            inventory.Add(new Product("silverbeet", 10, 50, "Marrow"));

            inventory.getCount();
            inventory.Add(new Product("potato", 10, 50, "Root"));
            Console.WriteLine("\nAfter Adding new item...");
            inventory.getCount();

            Console.WriteLine("\nPrinting the products which are type 'Leafy green'");
            inventory.findProduct("Leafy green");

            Console.WriteLine("Deleting garlic ...");
            inventory.deleteProduct("garlic");
            inventory.getCount();

            Console.WriteLine("Before Adding Number of Cabbages ...");
            inventory.printAll();

            inventory.addQuantity("cabbage", 50);
            Console.WriteLine();
            Console.WriteLine("After Adding Number of Cabbages ...");
            inventory.printAll();
            Console.WriteLine("\nNumber of items to buy: ");
            int count = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.Write("Item: ");
                string item = Console.ReadLine();
                Console.Write("Quantity: ");
                int quantity = Int32.Parse(Console.ReadLine());
                inventory.addCart(item.ToLower(), quantity);
            }

            Console.WriteLine("Total Amount: " + inventory.totalSum());

            //List<Inventory> inventories = new List<Inventory>
            //{
            //    new Inventory("lettuce", 10.5, 50, "Leafy green"),
            //    new Inventory("cabbage", 20, 100, "Cruciferous"),
            //    new Inventory("pumpkin", 30, 30, "Marrow"),
            //    new Inventory("cauliflower", 10, 25, "Cruciferous"),
            //    new Inventory("zucchini", 20.5, 50, "Marrow"),
            //    new Inventory("yam", 30, 50, "Root"),
            //    new Inventory("spinach", 10, 100, "Leafy green"),
            //    new Inventory("broccoli", 20.2, 75, "Cruciferous"),
            //    new Inventory("garlic", 30, 20, "Leafy green"),
            //    new Inventory("silverbeet", 10, 50, "Marrow")
            //};
            //string name;
            //string type;
            //double price;
            //int quantity;
            //inventory.totalProducts(inventories);
            //Console.WriteLine("Add new Product? (y/n):");
            //char input = Console.ReadKey().KeyChar;
            //if(input == 'y')
            //{
            //    Console.Write("Name of the product? : ");
            //    name = Console.ReadLine();
            //    Console.Write("Price of Product? : ");
            //    price = Double.Parse(Console.ReadLine());
            //    Console.WriteLine("Quantity of Product? : ");
            //    quantity = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("Type of Product? :");
            //    type = Console.ReadLine();


            //}


        }
    }
}
