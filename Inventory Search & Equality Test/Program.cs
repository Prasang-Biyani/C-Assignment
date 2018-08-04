using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = { "Tomato", "Potato", "ToMato", "Potato", "Red Tomato", "Tomato Catchup", "Grapes", "grapes", "potato" };
            int countTomato = 0;
            foreach (var product in products)
            {
                //Console.WriteLine(product);
                if (product.ToLower() == "tomato")
                    countTomato += 1;
            }
            Console.WriteLine("Number of Tomatoes: " + countTomato);

            int index = 0;
            foreach(var product in products)
            {
                if (product == "Potato")
                    Console.WriteLine("Potato at index: " + index);
                index++;
            }

            float X = 0.06f;
            float Y = 5.94f;

            if ((X + Y) == 6)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
            float max = X > Y ? X : Y;
            Console.WriteLine("Maximum is: " + max);
              
        }
    }
}
