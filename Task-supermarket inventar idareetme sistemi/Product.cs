using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_supermarket_inventar_idareetme_sistemi
{
    internal class Product
    {
        public string  Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product(string name,decimal price,string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
