using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }

        public Product(string name, double price, int quantity, string type )
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;
        }
        public override string ToString()
        {
            return Name + " " + Price + " " + Quantity + " " + Type;
        }
        
    }
}
