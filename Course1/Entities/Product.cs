using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1.Entities
{
    internal class Product
    {
        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public virtual string PriceTag()
        {
            return $"{Name} $ {Price} ";

        }
    }
}
